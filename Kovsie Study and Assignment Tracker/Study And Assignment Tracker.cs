using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kovsie_Study_and_Assignment_Tracker
{
    public partial class frmStudyAndAssignement : Form
    {
        private readonly List<Assignment> assignments = new List<Assignment>();
        private readonly List<string> modules = new List<string>();
        private readonly string dataFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "KovsieStudyAndAssignmentTracker",
            "assignments.json");
        private readonly string modulesFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "KovsieStudyAndAssignmentTracker",
            "modules.txt");

        private ComboBox cmbAssignmentModule;
        private TextBox txtSearch;
        private Label lblTotalAssignments;
        private Label lblOverdueAssignments;
        private Label lblModulesTracked;
        private Button btnDeleteAssignment;
        private Button btnSortAssignments;
        private Button btnSaveAndExit;

        public frmStudyAndAssignement()
        {
            InitializeComponent();
            BuildTrackerControls();
            WireEvents();
            LoadData();
            RefreshModuleList();
            RefreshAssignmentList();
        }

        private void BuildTrackerControls()
        {
            tbcAssignements.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            grpAddAssignment.BackColor = System.Drawing.Color.White;
            groupBox1.BackColor = System.Drawing.Color.White;
            grpEditAssignement.BackColor = System.Drawing.Color.White;
            grpAddAssignment.Text = "Add / Edit Assignment";
            groupBox1.Text = "Assignments";
            grpEditAssignement.Text = "Edit Selected Assignment";

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
            btnGuide.Location = new System.Drawing.Point(1076, 35);
            btnGuide.Size = new System.Drawing.Size(312, 60);
            btnGuide.Text = "Help / Guide";

            Label moduleLabel = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(555, 48),
                Text = "Module"
            };
            cmbAssignmentModule = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new System.Drawing.Point(560, 145),
                Size = new System.Drawing.Size(441, 31)
            };
            cmbAssignmentModule.Location = new System.Drawing.Point(560, 86);
            grpAddAssignment.Controls.Add(moduleLabel);
            grpAddAssignment.Controls.Add(cmbAssignmentModule);

            txtSearch = new TextBox
            {
                Location = new System.Drawing.Point(412, 310),
                Size = new System.Drawing.Size(360, 31)
            };
            txtSearch.Text = "Search by module or keyword";
            txtSearch.ForeColor = System.Drawing.Color.Gray;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            tbcAssignements.Controls.Add(txtSearch);

            btnSortAssignments = CreateActionButton("Sort by due date", 780, 308, 170);
            btnDeleteAssignment = CreateActionButton("Delete", 956, 308, 130);
            btnSaveAndExit = CreateActionButton("Save and exit", 870, 1040, 160);
            btnDeleteAssignment.ForeColor = System.Drawing.Color.Maroon;
            tbcAssignements.Controls.Add(btnSortAssignments);
            tbcAssignements.Controls.Add(btnDeleteAssignment);
            tbcAssignements.Controls.Add(btnSaveAndExit);

            lblTotalAssignments = CreateSummaryLabel("Total assignments: 0", 1100, 310);
            lblOverdueAssignments = CreateSummaryLabel("Overdue: 0", 1100, 350);
            lblModulesTracked = CreateSummaryLabel("Modules tracked: 0", 1100, 390);
            tbcAssignements.Controls.Add(lblTotalAssignments);
            tbcAssignements.Controls.Add(lblOverdueAssignments);
            tbcAssignements.Controls.Add(lblModulesTracked);

            groupBox1.Location = new System.Drawing.Point(17, 271);
            groupBox1.Size = new System.Drawing.Size(1013, 527);
            grpEditAssignement.Location = new System.Drawing.Point(17, 804);
            grpEditAssignement.Size = new System.Drawing.Size(1013, 235);
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
            btnDeleteAssignment.Click += btnDeleteAssignment_Click;
            btnSaveAndExit.Click += btnSaveAndExit_Click;
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
                assignments.Add(new Assignment("MATH1234", "Math Assignment 1", "Algebra practice", DateTime.Today.AddDays(-2)));
                assignments.Add(new Assignment("PHYS2048", "Physics Test Prep", "Revision notes", DateTime.Today.AddDays(2)));
                assignments.Add(new Assignment("HIST1101", "History Essay", "Essay draft", DateTime.Today.AddDays(5)));
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
            if (lstCurrentAssignments.SelectedItem == null)
            {
                return null;
            }

            string selectedText = lstCurrentAssignments.SelectedItem.ToString();
            return assignments.FirstOrDefault(a => a.ToString() == selectedText);
        }

        private IEnumerable<Assignment> GetVisibleAssignments()
        {
            string searchTerm = txtSearch == null ? string.Empty : txtSearch.Text.Trim();
            IEnumerable<Assignment> visible = assignments;
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                visible = visible.Where(a =>
                    a.Module.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            return visible.OrderBy(a => a.DueDate);
        }

        private void RefreshAssignmentList()
        {
            lstCurrentAssignments.Items.Clear();
            foreach (Assignment assignment in GetVisibleAssignments())
            {
                lstCurrentAssignments.Items.Add(assignment.ToString());
            }

            lblTotalAssignments.Text = "Total assignments: " + assignments.Count;
            lblOverdueAssignments.Text = "Overdue: " + assignments.Count(a => a.IsOverdue);
            lblModulesTracked.Text = "Modules tracked: " + modules.Count;
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            string moduleCode = txtModules.Text.Trim().ToUpperInvariant();
            if (!Regex.IsMatch(moduleCode, "^[A-Z]{4}[0-9]{4}$"))
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
            txtModules.Clear();
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
            int count = assignments.Count(a => a.Module == module);
            MessageBox.Show(string.Format("Module: {0}\nAssignments: {1}\nStatus: Active", module, count),
                "Module Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAssignment_add_Click(object sender, EventArgs e)
        {
            string title = txtAssignmentName_Add.Text.Trim();
            if (cmbAssignmentModule.SelectedItem == null || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Select a module and enter an assignment title.",
                    "Add Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            assignments.Add(new Assignment(
                cmbAssignmentModule.SelectedItem.ToString(),
                title,
                "No description provided",
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
            txtSearch.Text = string.Empty;
            lstCurrentAssignments.Items.Clear();
            foreach (Assignment assignment in assignments.Where(a => a.IsOverdue).OrderBy(a => a.DueDate))
            {
                lstCurrentAssignments.Items.Add(assignment.ToString());
            }
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
            if (selected == null || string.IsNullOrWhiteSpace(txtAssignment_edit.Text))
            {
                MessageBox.Show("Select an assignment and enter a title.",
                    "Update Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selected.Title = txtAssignment_edit.Text.Trim();
            selected.DueDate = dateTimePicker1.Value.Date;
            if (cmbAssignmentModule.SelectedItem != null)
            {
                selected.Module = cmbAssignmentModule.SelectedItem.ToString();
            }

            RefreshAssignmentList();
            SaveData();
            txtAssignment_edit.Clear();
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
            RefreshAssignmentList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by module or keyword")
            {
                return;
            }
            RefreshAssignmentList();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by module or keyword")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by module or keyword";
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
            MessageBox.Show("Use Add / Edit Assignment to manage records.\n" +
                "Search by module or title, sort by due date, mark work complete, " +
                "delete records, and use Save and exit to persist your data.",
                "Assignment Tracker Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
