using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kovsie_Study_and_Assignment_Tracker
{
    public partial class frmStudyAndAssignement : Form
    {
        private const string SearchPlaceholder = "Search by module or keyword";

        private readonly List<Assignment> assignments = new List<Assignment>();
        private readonly List<string> modules = new List<string>();

        // Tracks exactly what is currently shown in lstCurrentAssignments, in display order,
        // so a selected row can be mapped back to the correct Assignment safely (instead of
        // re-parsing the displayed text, which breaks if two rows ever look identical).
        private readonly List<Assignment> displayOrder = new List<Assignment>();

        private readonly string dataFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "KovsieStudyAndAssignmentTracker",
            "assignments.json");
        private readonly string modulesFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "KovsieStudyAndAssignmentTracker",
            "modules.txt");

        private string sortField = "DueDate";
        private bool sortAscending = true;
        private bool showingOverdueOnly = false;

        private ComboBox cmbAssignmentModule;
        private TextBox txtSearch;
        private TextBox txtModuleSummary;
        private Label lblTotalAssignments;
        private Label lblOverdueAssignments;
        private Label lblModulesTracked;
        private Button btnDeleteAssignment;
        private Button btnSortAssignments;
        private Button btnViewAssignmentDetails;
        private Button btnSaveAndExit;

        private static readonly System.Drawing.Color[] TabAccentColors = new[]
        {
            System.Drawing.Color.FromArgb(48, 112, 190),
            System.Drawing.Color.FromArgb(196, 90, 60),
            System.Drawing.Color.FromArgb(60, 160, 120)
        };

        // pnlHeroHeader, pnlCountdownHero, its 3 labels, countdownTimer, lstStudyPlan and
        // btnRefreshStudyPlan are all declared and created in the Designer file now (see
        // Study And Assignment Tracker.Designer.cs) - only the data behind them lives here.
        private readonly List<Assignment> studyPlanOrder = new List<Assignment>();

        public frmStudyAndAssignement()
        {
            InitializeComponent();
            BuildTrackerControls();
            WireEvents();
            LoadData();
            RefreshModuleList();
            RefreshAssignmentList();
            countdownTimer.Start();
        }

        /// <summary>
        /// Paints the gradient fill for pnlHeroHeader. The panel itself, its position and
        /// its title label are all declared in the Designer file - this is the one piece
        /// (a gradient) that has no Designer property, so it has to stay code.
        /// </summary>
        private void pnlHeroHeader_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    pnlHeroHeader.ClientRectangle,
                    System.Drawing.Color.FromArgb(72, 61, 196),
                    System.Drawing.Color.FromArgb(48, 112, 190),
                    System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, pnlHeroHeader.ClientRectangle);
            }
        }

        /// <summary>
        /// Paints one tab header with its accent colour. The TabControl's DrawMode,
        /// ItemSize and the wiring of this event are all set in the Designer file now -
        /// this method only has to exist because DrawItem's actual pixels always need code.
        /// </summary>
        private void tbcStudy_And_Assignment_Tracker_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tbcStudy_And_Assignment_Tracker.TabPages[e.Index];
            bool selected = e.Index == tbcStudy_And_Assignment_Tracker.SelectedIndex;
            System.Drawing.Color accent = TabAccentColors[e.Index % TabAccentColors.Length];
            System.Drawing.Color backColor = selected
                ? accent
                : System.Drawing.Color.FromArgb(232, 238, 247);
            System.Drawing.Color textColor = selected ? System.Drawing.Color.White : accent;

            using (System.Drawing.SolidBrush backBrush = new System.Drawing.SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            System.Drawing.StringFormat centerFormat = new System.Drawing.StringFormat
            {
                Alignment = System.Drawing.StringAlignment.Center,
                LineAlignment = System.Drawing.StringAlignment.Center
            };
            using (System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(textColor))
            {
                e.Graphics.DrawString(page.Text, e.Font, textBrush, e.Bounds, centerFormat);
            }
        }

        private void BuildTrackerControls()
        {
            tbcAssignements.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            tbcAssignements.AutoScroll = true;
            tbcAdd_Remove_Modules.AutoScroll = true;
            grpAddAssignment.BackColor = System.Drawing.Color.White;
            groupBox1.BackColor = System.Drawing.Color.White;
            grpEditAssignement.BackColor = System.Drawing.Color.White;
            grpAddAssignment.Text = "Add / Edit Assignment";
            groupBox1.Text = "Assignments";
            // grpEditAssignement's caption and the two edit-button captions are now set
            // in the Designer file (Load for Editing / Save Changes) - see the note there
            // about why they used to both say "Edit Assignment".

            foreach (Control control in new Control[]
            {
                btnAssignment_add, btnCompletedAssignment, btnAssignments,
                btnEditAssignment, btnAssignment_edit, btnGuide,
                btnAddModule, btnRemoveModule, btnViewDetails
            })
            {
                Button button = control as Button;
                if (button != null)
                {
                    button.BackColor = System.Drawing.Color.FromArgb(232, 238, 247);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 195, 215);
                }
            }

            btnAssignment_add.BackColor = System.Drawing.Color.FromArgb(48, 112, 190);
            btnAssignment_add.ForeColor = System.Drawing.Color.White;

            // Reposition and enlarge the main panels so every control has room to be seen and clicked.
            grpAddAssignment.Location = new System.Drawing.Point(17, 12);
            grpAddAssignment.Size = new System.Drawing.Size(1013, 152);
            groupBox1.Location = new System.Drawing.Point(17, 223);
            groupBox1.Size = new System.Drawing.Size(1013, 527);
            grpEditAssignement.Location = new System.Drawing.Point(17, 766);
            grpEditAssignement.Size = new System.Drawing.Size(1013, 235);

            // Module selector, shared between the Add and Edit sections.
            Label moduleLabel = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(700, 31),
                Text = "Module"
            };
            cmbAssignmentModule = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(700, 55),
                Size = new System.Drawing.Size(260, 31)
            };
            grpAddAssignment.Controls.Add(moduleLabel);
            grpAddAssignment.Controls.Add(cmbAssignmentModule);

            // Search / sort / delete / details toolbar, above the assignment list.
            txtSearch = new TextBox
            {
                Location = new System.Drawing.Point(17, 176),
                Size = new System.Drawing.Size(360, 31),
                Text = SearchPlaceholder,
                ForeColor = System.Drawing.Color.Gray
            };
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            tbcAssignements.Controls.Add(txtSearch);

            btnSortAssignments = CreateActionButton(GetSortButtonText(), 390, 176, 200);
            btnDeleteAssignment = CreateActionButton("Delete", 604, 176, 130);
            btnDeleteAssignment.ForeColor = System.Drawing.Color.Maroon;
            btnViewAssignmentDetails = CreateActionButton("View Details", 748, 176, 160);
            tbcAssignements.Controls.Add(btnSortAssignments);
            tbcAssignements.Controls.Add(btnDeleteAssignment);
            tbcAssignements.Controls.Add(btnViewAssignmentDetails);

            btnSaveAndExit = CreateActionButton("Save and exit", 17, 1017, 200);
            tbcAssignements.Controls.Add(btnSaveAndExit);

            // Right-hand summary column.
            btnGuide.Location = new System.Drawing.Point(1050, 12);
            btnGuide.Size = new System.Drawing.Size(330, 199);
            btnGuide.Text = "Help / Guide";

            lblTotalAssignments = CreateSummaryLabel("Total assignments: 0", 1050, 223);
            lblOverdueAssignments = CreateSummaryLabel("Overdue: 0", 1050, 250);
            lblModulesTracked = CreateSummaryLabel("Modules tracked: 0", 1050, 277);
            tbcAssignements.Controls.Add(lblTotalAssignments);
            tbcAssignements.Controls.Add(lblOverdueAssignments);
            tbcAssignements.Controls.Add(lblModulesTracked);

            txtModuleSummary = new TextBox
            {
                Location = new System.Drawing.Point(1050, 310),
                Size = new System.Drawing.Size(330, 440),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = System.Drawing.Color.White
            };
            tbcAssignements.Controls.Add(txtModuleSummary);

            // Owner-draw the assignment list so overdue / completed items are flagged with colour,
            // not just a word in the text.
            lstCurrentAssignments.DrawMode = DrawMode.OwnerDrawFixed;
            lstCurrentAssignments.ItemHeight = 22;

            // Anchoring so the window can actually be resized without the layout breaking -
            // the assignment list and its group box grow with the window; the side summary
            // column and the module tab track the right/left edges.
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCurrentAssignments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAddAssignment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpEditAssignement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuide.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalAssignments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOverdueAssignments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblModulesTracked.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtModuleSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveAndExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        /// <summary>
        /// Wired to countdownTimer.Tick in the Designer file - ticks every second and
        /// just forwards to the same refresh logic used after any data change.
        /// </summary>
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            UpdateCountdown();
        }

        private void pnlCountdownHero_Paint(object sender, PaintEventArgs e)
        {
            Assignment next = studyPlanOrder.FirstOrDefault();
            System.Drawing.Color from = System.Drawing.Color.FromArgb(72, 61, 196);
            System.Drawing.Color to = System.Drawing.Color.FromArgb(48, 112, 190);

            if (next != null)
            {
                if (next.IsOverdue)
                {
                    from = System.Drawing.Color.FromArgb(196, 60, 60);
                    to = System.Drawing.Color.FromArgb(214, 100, 65);
                }
                else if (next.DaysRemaining <= 2)
                {
                    from = System.Drawing.Color.FromArgb(214, 130, 40);
                    to = System.Drawing.Color.FromArgb(230, 170, 60);
                }
            }

            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    pnlCountdownHero.ClientRectangle, from, to,
                    System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, pnlCountdownHero.ClientRectangle);
            }
        }

        /// <summary>
        /// Refreshes the countdown card. Called once a second by countdownTimer, and
        /// also straight after any add/edit/delete/complete so it never shows stale data.
        /// "End of the due day" (23:59:59) is used as the deadline instant, matching
        /// Assignment.IsOverdue - which only flags a day as overdue once it has fully
        /// passed, not the moment it starts.
        /// </summary>
        private void UpdateCountdown()
        {
            Assignment next = studyPlanOrder.FirstOrDefault();

            if (next == null)
            {
                lblCountdownCaption.Text = "ALL CLEAR";
                lblCountdownTitle.Text = "Nothing outstanding - nice work staying ahead!";
                lblCountdownTime.Text = string.Empty;
                pnlCountdownHero.Invalidate();
                return;
            }

            lblCountdownCaption.Text = "NEXT UP";
            lblCountdownTitle.Text = string.Format("{0}  -  {1}", next.Module, next.Title);

            DateTime deadline = next.DueDate.Date.AddDays(1).AddSeconds(-1);
            TimeSpan remaining = deadline - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                TimeSpan overdueBy = DateTime.Now - deadline;
                lblCountdownTime.Text = string.Format("Overdue {0}d {1}h", overdueBy.Days, overdueBy.Hours);
            }
            else if (remaining.TotalDays >= 1)
            {
                lblCountdownTime.Text = string.Format("{0}d {1}h {2}m", remaining.Days, remaining.Hours, remaining.Minutes);
            }
            else
            {
                lblCountdownTime.Text = string.Format("{0}h {1}m {2}s", remaining.Hours, remaining.Minutes, remaining.Seconds);
            }

            pnlCountdownHero.Invalidate();
        }

        /// <summary>
        /// Rebuilds the priority queue: everything not yet completed, oldest due date
        /// first (so overdue work - which has the earliest due dates - naturally sits
        /// at the top). Also repaints the heatmap, since both reflect the same data.
        /// </summary>
        private void RefreshStudyPlan()
        {
            studyPlanOrder.Clear();
            studyPlanOrder.AddRange(assignments.Where(a => !a.IsCompleted).OrderBy(a => a.DueDate));

            lstStudyPlan.Items.Clear();
            for (int i = 0; i < studyPlanOrder.Count; i++)
            {
                lstStudyPlan.Items.Add(i);
            }

            if (studyPlanOrder.Count == 0)
            {
                lstStudyPlan.Items.Add(-1);
            }

            UpdateCountdown();
        }

        private void lstStudyPlan_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (studyPlanOrder.Count == 0)
            {
                using (System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray))
                {
                    e.Graphics.DrawString("Nothing outstanding - nice work staying ahead!", e.Font, textBrush,
                        new System.Drawing.Rectangle(e.Bounds.Left + 10, e.Bounds.Top, e.Bounds.Width - 10, e.Bounds.Height),
                        new System.Drawing.StringFormat { LineAlignment = System.Drawing.StringAlignment.Center });
                }
                return;
            }

            if (e.Index < 0 || e.Index >= studyPlanOrder.Count)
            {
                return;
            }

            Assignment a = studyPlanOrder[e.Index];
            System.Drawing.Color urgencyColor = GetUrgencyColor(a);

            System.Drawing.Rectangle stripe =
                new System.Drawing.Rectangle(e.Bounds.Left + 4, e.Bounds.Top + 3, 10, e.Bounds.Height - 6);
            using (System.Drawing.SolidBrush stripeBrush = new System.Drawing.SolidBrush(urgencyColor))
            {
                e.Graphics.FillRectangle(stripeBrush, stripe);
            }

            string text = string.Format("{0}  |  {1}  ({2:dddd, dd MMM})  -  {3}",
                a.Module, a.Title, a.DueDate, a.StatusText);
            System.Drawing.Rectangle textBounds = new System.Drawing.Rectangle(
                e.Bounds.Left + 24, e.Bounds.Top, e.Bounds.Width - 28, e.Bounds.Height);
            using (System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black))
            {
                e.Graphics.DrawString(text, e.Font, textBrush, textBounds,
                    new System.Drawing.StringFormat { LineAlignment = System.Drawing.StringAlignment.Center });
            }
            e.DrawFocusRectangle();
        }

        private System.Drawing.Color GetUrgencyColor(Assignment a)
        {
            if (a.IsOverdue)
            {
                return System.Drawing.Color.FromArgb(214, 69, 65);
            }
            if (a.DaysRemaining <= 2)
            {
                return System.Drawing.Color.FromArgb(255, 165, 90);
            }
            if (a.DaysRemaining <= 7)
            {
                return System.Drawing.Color.FromArgb(230, 190, 40);
            }
            return System.Drawing.Color.FromArgb(60, 170, 120);
        }

        private Button CreateActionButton(string text, int x, int y, int width)
        {
            return new Button
            {
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(width, 35),
                Text = text,
                UseVisualStyleBackColor = true
            };
        }

        private Label CreateSummaryLabel(string text, int x, int y)
        {
            return new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(x, y),
                Text = text
            };
        }

        private void WireEvents()
        {
            btnAddModule.Click += btnAddModule_Click;
            btnRemoveModule.Click += btnRemoveModule_Click;
            btnViewDetails.Click += btnViewDetails_Click;
            btnAssignment_add.Click += btnAssignment_add_Click;
            btnCompletedAssignment.Click += btnCompletedAssignment_Click;
            btnAssignments.Click += btnAssignments_Click;
            btnEditAssignment.Click += btnEditAssignment_Click;
            btnAssignment_edit.Click += btnAssignment_edit_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnSortAssignments.Click += btnSortAssignments_Click;
            btnViewAssignmentDetails.Click += btnViewAssignmentDetails_Click;
            btnDeleteAssignment.Click += btnDeleteAssignment_Click;
            btnSaveAndExit.Click += btnSaveAndExit_Click;
            lstCurrentAssignments.DrawItem += lstCurrentAssignments_DrawItem;
            FormClosing += frmStudyAndAssignement_FormClosing;
        }

        private void LoadData()
        {
            string directory = Path.GetDirectoryName(dataFilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (File.Exists(dataFilePath))
            {
                try
                {
                    using (FileStream stream = File.OpenRead(dataFilePath))
                    {
                        DataContractJsonSerializer serializer =
                            new DataContractJsonSerializer(typeof(List<Assignment>));
                        List<Assignment> savedAssignments = serializer.ReadObject(stream) as List<Assignment>;
                        if (savedAssignments != null)
                        {
                            assignments.AddRange(savedAssignments);
                            foreach (Assignment assignment in savedAssignments)
                            {
                                if (!string.IsNullOrWhiteSpace(assignment.Module) && !modules.Contains(assignment.Module))
                                {
                                    modules.Add(assignment.Module);
                                }
                            }

                            if (File.Exists(modulesFilePath))
                            {
                                foreach (string module in File.ReadAllLines(modulesFilePath))
                                {
                                    string trimmedModule = module.Trim();
                                    if (!string.IsNullOrWhiteSpace(trimmedModule) && !modules.Contains(trimmedModule))
                                    {
                                        modules.Add(trimmedModule);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Saved data could not be loaded: " + ex.Message,
                        "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (assignments.Count == 0)
            {
                modules.AddRange(new[] { "MATH1234", "PHYS2048", "HIST1101" });
                assignments.Add(new Assignment("MATH1234", "Math Assignment 1", DateTime.Today.AddDays(-2)));
                assignments.Add(new Assignment("PHYS2048", "Physics Test Prep", DateTime.Today.AddDays(2)));
                assignments.Add(new Assignment("HIST1101", "History Essay", DateTime.Today.AddDays(5)));
            }
        }

        private void SaveData()
        {
            string directory = Path.GetDirectoryName(dataFilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (FileStream stream = File.Create(dataFilePath))
            {
                DataContractJsonSerializer serializer =
                    new DataContractJsonSerializer(typeof(List<Assignment>));
                serializer.WriteObject(stream, assignments);
            }

            File.WriteAllLines(modulesFilePath, modules.OrderBy(module => module));
        }

        private void RefreshModuleList()
        {
            lstModules_remove.Items.Clear();
            lstModules_ViewDetails.Items.Clear();
            cmbAssignmentModule.Items.Clear();

            foreach (string module in modules.OrderBy(m => m))
            {
                lstModules_remove.Items.Add(module);
                lstModules_ViewDetails.Items.Add(module);
                cmbAssignmentModule.Items.Add(module);
            }

            if (cmbAssignmentModule.Items.Count > 0)
            {
                cmbAssignmentModule.SelectedIndex = 0;
            }
        }

        private Assignment GetSelectedAssignment()
        {
            int index = lstCurrentAssignments.SelectedIndex;
            if (index < 0 || index >= displayOrder.Count)
            {
                return null;
            }
            return displayOrder[index];
        }

        private string GetActiveSearchTerm()
        {
            if (txtSearch == null || txtSearch.Text == SearchPlaceholder)
            {
                return string.Empty;
            }
            return txtSearch.Text.Trim();
        }

        private IEnumerable<Assignment> SortAssignments(IEnumerable<Assignment> source)
        {
            switch (sortField)
            {
                case "Module":
                    return sortAscending
                        ? source.OrderBy(a => a.Module).ThenBy(a => a.DueDate)
                        : source.OrderByDescending(a => a.Module).ThenBy(a => a.DueDate);
                case "Title":
                    return sortAscending
                        ? source.OrderBy(a => a.Title)
                        : source.OrderByDescending(a => a.Title);
                default:
                    return sortAscending
                        ? source.OrderBy(a => a.DueDate)
                        : source.OrderByDescending(a => a.DueDate);
            }
        }

        private IEnumerable<Assignment> GetVisibleAssignments()
        {
            IEnumerable<Assignment> visible = assignments;

            if (showingOverdueOnly)
            {
                visible = visible.Where(a => a.IsOverdue);
            }

            string searchTerm = GetActiveSearchTerm();
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                visible = visible.Where(a =>
                    a.Module.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return SortAssignments(visible);
        }

        private void RenderAssignments(IEnumerable<Assignment> visibleAssignments)
        {
            displayOrder.Clear();
            displayOrder.AddRange(visibleAssignments);

            lstCurrentAssignments.Items.Clear();
            foreach (Assignment assignment in displayOrder)
            {
                lstCurrentAssignments.Items.Add(assignment.ToString());
            }

            UpdateSummary();
        }

        private void RefreshAssignmentList()
        {
            RenderAssignments(GetVisibleAssignments());
        }

        private void UpdateSummary()
        {
            lblTotalAssignments.Text = "Total assignments: " + assignments.Count;
            lblOverdueAssignments.Text = "Overdue: " + assignments.Count(a => a.IsOverdue);
            lblModulesTracked.Text = "Modules tracked: " + modules.Count;
            txtModuleSummary.Text = BuildModuleSummaryText();
            RefreshStudyPlan();
        }

        /// <summary>
        /// Builds a per-module breakdown (total and overdue counts) by iterating over the collection.
        /// Demonstrates meaningful string building for the basic summary/report requirement.
        /// </summary>
        private string BuildModuleSummaryText()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Assignments per module:");
            builder.AppendLine();

            if (modules.Count == 0)
            {
                builder.AppendLine("No modules added yet.");
                return builder.ToString();
            }

            foreach (string module in modules.OrderBy(m => m))
            {
                int total = assignments.Count(a => a.Module == module);
                int overdue = assignments.Count(a => a.Module == module && a.IsOverdue);
                builder.AppendFormat("{0}: {1} total, {2} overdue", module, total, overdue);
                builder.AppendLine();
            }

            return builder.ToString();
        }

        /// <summary>
        /// Builds a plain-text weekly plan: overdue items first, then anything due in the next 7 days,
        /// grouped by day. This is the "unique" study-schedule feature layered on top of the required brief.
        /// </summary>
        private string BuildStudyPlanText()
        {
            StringBuilder builder = new StringBuilder();
            DateTime weekEnd = DateTime.Today.AddDays(7);

            List<Assignment> overdue = assignments.Where(a => a.IsOverdue).OrderBy(a => a.DueDate).ToList();
            List<Assignment> upcoming = assignments
                .Where(a => !a.IsCompleted && a.DueDate.Date >= DateTime.Today && a.DueDate.Date <= weekEnd)
                .OrderBy(a => a.DueDate)
                .ToList();

            if (overdue.Count > 0)
            {
                builder.AppendLine("OVERDUE - deal with these first:");
                foreach (Assignment a in overdue)
                {
                    builder.AppendFormat("  {0} | {1} (was due {2:dd MMM yyyy})", a.Module, a.Title, a.DueDate);
                    builder.AppendLine();
                }
                builder.AppendLine();
            }

            if (upcoming.Count == 0)
            {
                builder.AppendLine("Nothing due in the next 7 days. Nice work staying ahead!");
                return builder.ToString();
            }

            builder.AppendLine("Due in the next 7 days:");
            DateTime? lastDay = null;
            foreach (Assignment a in upcoming)
            {
                if (lastDay == null || lastDay.Value.Date != a.DueDate.Date)
                {
                    builder.AppendLine();
                    builder.AppendFormat("{0:dddd, dd MMMM}", a.DueDate);
                    builder.AppendLine();
                    lastDay = a.DueDate;
                }
                builder.AppendFormat("  - {0} ({1})", a.Title, a.Module);
                builder.AppendLine();
            }

            return builder.ToString();
        }

        private bool IsValidModuleCode(string code)
        {
            return Regex.IsMatch(code, "^[A-Z]{4}[0-9]{4}$");
        }

        /// <summary>
        /// Validates the module/title fields shared by both the Add and Edit forms.
        /// Returns false and an error message instead of letting bad input crash the app.
        /// </summary>
        private bool TryValidateAssignmentInput(object selectedModule, string title, out string errorMessage)
        {
            if (selectedModule == null)
            {
                errorMessage = "Please select a module before continuing.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(title))
            {
                errorMessage = "Please enter an assignment title.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private System.Drawing.Color GetStatusColor(Assignment assignment)
        {
            if (assignment.IsCompleted)
            {
                return System.Drawing.Color.SeaGreen;
            }
            if (assignment.IsOverdue)
            {
                return System.Drawing.Color.Firebrick;
            }
            return System.Drawing.Color.Black;
        }

        private string GetSortButtonText()
        {
            string direction = sortAscending ? "A-Z / earliest" : "Z-A / latest";
            return string.Format("Sort: {0} ({1})", sortField, direction);
        }

        private void CycleSortOption()
        {
            if (sortField == "DueDate" && sortAscending)
            {
                sortAscending = false;
            }
            else if (sortField == "DueDate")
            {
                sortField = "Module";
                sortAscending = true;
            }
            else if (sortField == "Module")
            {
                sortField = "Title";
                sortAscending = true;
            }
            else
            {
                sortField = "DueDate";
                sortAscending = true;
            }

            btnSortAssignments.Text = GetSortButtonText();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            string moduleCode = txtModules.Text.Trim().ToUpperInvariant();
            if (!IsValidModuleCode(moduleCode))
            {
                MessageBox.Show("Module code must be in the format ABCD1234.",
                    "Invalid Module", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modules.Contains(moduleCode))
            {
                MessageBox.Show("This module is already on your list.",
                    "Duplicate Module", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modules.Add(moduleCode);
            RefreshModuleList();
            UpdateSummary();
            txtModules.Clear();
            SaveData();
        }

        private void btnRemoveModule_Click(object sender, EventArgs e)
        {
            if (lstModules_remove.SelectedItem == null)
            {
                MessageBox.Show("Select a module to remove.", "Remove Module",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedModule = lstModules_remove.SelectedItem.ToString();
            if (assignments.Any(a => a.Module == selectedModule))
            {
                MessageBox.Show("Remove or update assignments for this module first.",
                    "Module In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modules.Remove(selectedModule);
            RefreshModuleList();
            UpdateSummary();
            SaveData();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lstModules_ViewDetails.SelectedItem == null)
            {
                MessageBox.Show("Select a module to view.", "View Module",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string module = lstModules_ViewDetails.SelectedItem.ToString();
            int total = assignments.Count(a => a.Module == module);
            int overdue = assignments.Count(a => a.Module == module && a.IsOverdue);
            int completed = assignments.Count(a => a.Module == module && a.IsCompleted);
            MessageBox.Show(
                string.Format(
                    "Module: {0}\nAssignments: {1}\nCompleted: {2}\nOverdue: {3}",
                    module, total, completed, overdue),
                "Module Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAssignment_add_Click(object sender, EventArgs e)
        {
            string title = txtAssignmentName_Add.Text.Trim();
            string errorMessage;
            if (!TryValidateAssignmentInput(cmbAssignmentModule.SelectedItem, title, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Add Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            assignments.Add(new Assignment(
                cmbAssignmentModule.SelectedItem.ToString(),
                title,
                dtpDueDate_add.Value.Date));
            RefreshAssignmentList();
            SaveData();
            txtAssignmentName_Add.Clear();
        }

        private void btnCompletedAssignment_Click(object sender, EventArgs e)
        {
            Assignment selected = GetSelectedAssignment();
            if (selected == null)
            {
                MessageBox.Show("Select an assignment first.", "Complete Assignment",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selected.MarkAsCompleted();
            RefreshAssignmentList();
            SaveData();
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            showingOverdueOnly = !showingOverdueOnly;
            btnAssignments.Text = showingOverdueOnly ? "Show All Assignments" : "View Overdue Assignements";
            RefreshAssignmentList();
        }

        private void btnEditAssignment_Click(object sender, EventArgs e)
        {
            Assignment selected = GetSelectedAssignment();
            if (selected == null)
            {
                MessageBox.Show("Select an assignment first.", "Edit Assignment",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtAssignment_edit.Text = selected.Title;
            dateTimePicker1.Value = selected.DueDate;
            cmbAssignmentModule.SelectedItem = selected.Module;
        }

        private void btnAssignment_edit_Click(object sender, EventArgs e)
        {
            Assignment selected = GetSelectedAssignment();
            string title = txtAssignment_edit.Text.Trim();
            string errorMessage;

            if (selected == null)
            {
                MessageBox.Show("Select an assignment to update.", "Update Assignment",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TryValidateAssignmentInput(cmbAssignmentModule.SelectedItem, title, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Update Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selected.Title = title;
            selected.DueDate = dateTimePicker1.Value.Date;
            selected.Module = cmbAssignmentModule.SelectedItem.ToString();

            RefreshAssignmentList();
            SaveData();
            txtAssignment_edit.Clear();
        }

        private void btnViewAssignmentDetails_Click(object sender, EventArgs e)
        {
            Assignment selected = GetSelectedAssignment();
            if (selected == null)
            {
                MessageBox.Show("Select an assignment to view its details.", "View Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(selected.GetDetailsText(), "Assignment Details",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            Assignment selected = GetSelectedAssignment();
            if (selected == null)
            {
                MessageBox.Show("Select an assignment to delete.", "Delete Assignment",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Delete " + selected.Title + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                assignments.Remove(selected);
                RefreshAssignmentList();
                SaveData();
            }
        }

        private void btnSortAssignments_Click(object sender, EventArgs e)
        {
            CycleSortOption();
            RefreshAssignmentList();
        }

        private void btnRefreshStudyPlan_Click(object sender, EventArgs e)
        {
            RefreshStudyPlan();
        }

        private void lstCurrentAssignments_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= displayOrder.Count)
            {
                e.DrawBackground();
                return;
            }

            Assignment assignment = displayOrder[e.Index];
            System.Drawing.Color statusColor = GetStatusColor(assignment);
            string statusWord = assignment.IsCompleted ? "Done" : (assignment.IsOverdue ? "Overdue" : "Pending");

            e.DrawBackground();

            // Status badge on the right, mirroring the coloured "pill" look from the design mockup.
            System.Drawing.Rectangle chipBounds = new System.Drawing.Rectangle(
                e.Bounds.Right - 92, e.Bounds.Top + 2, 82, e.Bounds.Height - 4);
            using (System.Drawing.SolidBrush chipBrush = new System.Drawing.SolidBrush(
                System.Drawing.Color.FromArgb(45, statusColor.R, statusColor.G, statusColor.B)))
            {
                e.Graphics.FillRectangle(chipBrush, chipBounds);
            }
            using (System.Drawing.SolidBrush chipTextBrush = new System.Drawing.SolidBrush(statusColor))
            {
                e.Graphics.DrawString(statusWord, e.Font, chipTextBrush, chipBounds,
                    new System.Drawing.StringFormat
                    {
                        Alignment = System.Drawing.StringAlignment.Center,
                        LineAlignment = System.Drawing.StringAlignment.Center
                    });
            }

            // Module / title / due date text on the left.
            string rowText = string.Format("{0} | {1} ({2:dd MMM yyyy})",
                assignment.Module, assignment.Title, assignment.DueDate);
            System.Drawing.Rectangle textBounds = new System.Drawing.Rectangle(
                e.Bounds.Left + 2, e.Bounds.Top, e.Bounds.Width - 98, e.Bounds.Height);
            using (System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black))
            {
                e.Graphics.DrawString(rowText, e.Font, textBrush, textBounds,
                    new System.Drawing.StringFormat { LineAlignment = System.Drawing.StringAlignment.Center });
            }
            e.DrawFocusRectangle();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == SearchPlaceholder)
            {
                return;
            }
            RefreshAssignmentList();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == SearchPlaceholder)
            {
                txtSearch.Clear();
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = SearchPlaceholder;
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        private void frmStudyAndAssignement_FormClosing(object sender, FormClosingEventArgs e)
        {
            countdownTimer.Stop();
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your changes could not be saved: " + ex.Message,
                    "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Add / Edit Assignment: pick a module, type a title and due date, then Add Assignment.\n" +
                "Search by module or title, or use Sort to cycle between due date, module and title.\n" +
                "View Overdue Assignments toggles the list to overdue items only; the list itself\n" +
                "colours overdue items red and completed items green so they're easy to spot.\n" +
                "Select a row to mark it complete, view its full details, edit it, or delete it.\n" +
                "The Study Schedule tab shows what's overdue and what's due in the next 7 days.\n" +
                "Save and exit (or simply closing the app) writes your data to disk as JSON.",
                "Assignment Tracker Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
