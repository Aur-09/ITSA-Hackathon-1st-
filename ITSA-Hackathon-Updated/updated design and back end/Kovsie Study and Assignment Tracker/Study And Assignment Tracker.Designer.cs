
namespace Kovsie_Study_and_Assignment_Tracker
{
    partial class frmStudyAndAssignement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeroHeader = new System.Windows.Forms.Panel();
            this.lblHeroTitle = new System.Windows.Forms.Label();
            this.pnlCountdownHero = new System.Windows.Forms.Panel();
            this.lblCountdownCaption = new System.Windows.Forms.Label();
            this.lblCountdownTitle = new System.Windows.Forms.Label();
            this.lblCountdownTime = new System.Windows.Forms.Label();
            this.lblStudyPlanTitle = new System.Windows.Forms.Label();
            this.lblPriorityQueueHeader = new System.Windows.Forms.Label();
            this.btnRefreshStudyPlan = new System.Windows.Forms.Button();
            this.lstStudyPlan = new System.Windows.Forms.ListBox();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.tbcStudy_And_Assignment_Tracker = new System.Windows.Forms.TabControl();
            this.tbcAdd_Remove_Modules = new System.Windows.Forms.TabPage();
            this.pnlModulesAccent = new System.Windows.Forms.Panel();
            this.grpViewModuleDetails = new System.Windows.Forms.GroupBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lstModules_ViewDetails = new System.Windows.Forms.ListBox();
            this.grpRemoveModule = new System.Windows.Forms.GroupBox();
            this.btnRemoveModule = new System.Windows.Forms.Button();
            this.lstModules_remove = new System.Windows.Forms.ListBox();
            this.grpAddModules = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.txtModules = new System.Windows.Forms.TextBox();
            this.tbcAssignements = new System.Windows.Forms.TabPage();
            this.pnlAssignmentsAccent = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSortAssignments = new System.Windows.Forms.Button();
            this.btnDeleteAssignment = new System.Windows.Forms.Button();
            this.btnViewAssignmentDetails = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.lblTotalAssignments = new System.Windows.Forms.Label();
            this.lblOverdueAssignments = new System.Windows.Forms.Label();
            this.lblModulesTracked = new System.Windows.Forms.Label();
            this.txtModuleSummary = new System.Windows.Forms.TextBox();
            this.btnGuide = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditAssignment = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.btnCompletedAssignment = new System.Windows.Forms.Button();
            this.lstCurrentAssignments = new System.Windows.Forms.ListBox();
            this.grpEditAssignement = new System.Windows.Forms.GroupBox();
            this.txtAssignment_edit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAssignment_edit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAddAssignment = new System.Windows.Forms.GroupBox();
            this.lblModuleSelect = new System.Windows.Forms.Label();
            this.cmbAssignmentModule = new System.Windows.Forms.ComboBox();
            this.btnAssignment_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssignmentName_Add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDueDate_add = new System.Windows.Forms.DateTimePicker();
            this.tbcStudySchedule = new System.Windows.Forms.TabPage();
            this.pnlScheduleAccent = new System.Windows.Forms.Panel();
            this.pnlHeroHeader.SuspendLayout();
            this.pnlCountdownHero.SuspendLayout();
            this.tbcStudy_And_Assignment_Tracker.SuspendLayout();
            this.tbcAdd_Remove_Modules.SuspendLayout();
            this.grpViewModuleDetails.SuspendLayout();
            this.grpRemoveModule.SuspendLayout();
            this.grpAddModules.SuspendLayout();
            this.tbcAssignements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpEditAssignement.SuspendLayout();
            this.grpAddAssignment.SuspendLayout();
            this.tbcStudySchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeroHeader
            // 
            this.pnlHeroHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeroHeader.Controls.Add(this.lblHeroTitle);
            this.pnlHeroHeader.Location = new System.Drawing.Point(8, 8);
            this.pnlHeroHeader.Name = "pnlHeroHeader";
            this.pnlHeroHeader.Size = new System.Drawing.Size(1454, 60);
            this.pnlHeroHeader.TabIndex = 100;
            this.pnlHeroHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeroHeader_Paint);
            // 
            // lblHeroTitle
            // 
            this.lblHeroTitle.AutoSize = true;
            this.lblHeroTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeroTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeroTitle.Location = new System.Drawing.Point(20, 14);
            this.lblHeroTitle.Name = "lblHeroTitle";
            this.lblHeroTitle.Size = new System.Drawing.Size(448, 37);
            this.lblHeroTitle.TabIndex = 0;
            this.lblHeroTitle.Text = "Kovsie Study & Assignment Tracker";
            // 
            // pnlCountdownHero
            // 
            this.pnlCountdownHero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCountdownHero.Controls.Add(this.lblCountdownCaption);
            this.pnlCountdownHero.Controls.Add(this.lblCountdownTitle);
            this.pnlCountdownHero.Controls.Add(this.lblCountdownTime);
            this.pnlCountdownHero.Location = new System.Drawing.Point(17, 61);
            this.pnlCountdownHero.Name = "pnlCountdownHero";
            this.pnlCountdownHero.Size = new System.Drawing.Size(950, 130);
            this.pnlCountdownHero.TabIndex = 0;
            this.pnlCountdownHero.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCountdownHero_Paint);
            // 
            // lblCountdownCaption
            // 
            this.lblCountdownCaption.AutoSize = true;
            this.lblCountdownCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountdownCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.lblCountdownCaption.Location = new System.Drawing.Point(24, 14);
            this.lblCountdownCaption.Name = "lblCountdownCaption";
            this.lblCountdownCaption.Size = new System.Drawing.Size(80, 23);
            this.lblCountdownCaption.TabIndex = 0;
            this.lblCountdownCaption.Text = "NEXT UP";
            // 
            // lblCountdownTitle
            // 
            this.lblCountdownTitle.AutoSize = true;
            this.lblCountdownTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCountdownTitle.ForeColor = System.Drawing.Color.White;
            this.lblCountdownTitle.Location = new System.Drawing.Point(24, 40);
            this.lblCountdownTitle.MaximumSize = new System.Drawing.Size(540, 0);
            this.lblCountdownTitle.Name = "lblCountdownTitle";
            this.lblCountdownTitle.Size = new System.Drawing.Size(114, 30);
            this.lblCountdownTitle.TabIndex = 1;
            this.lblCountdownTitle.Text = "Loading...";
            // 
            // lblCountdownTime
            // 
            this.lblCountdownTime.AutoSize = true;
            this.lblCountdownTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownTime.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCountdownTime.ForeColor = System.Drawing.Color.White;
            this.lblCountdownTime.Location = new System.Drawing.Point(600, 36);
            this.lblCountdownTime.Name = "lblCountdownTime";
            this.lblCountdownTime.Size = new System.Drawing.Size(0, 60);
            this.lblCountdownTime.TabIndex = 2;
            // 
            // lblStudyPlanTitle
            // 
            this.lblStudyPlanTitle.AutoSize = true;
            this.lblStudyPlanTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStudyPlanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(190)))));
            this.lblStudyPlanTitle.Location = new System.Drawing.Point(17, 17);
            this.lblStudyPlanTitle.Name = "lblStudyPlanTitle";
            this.lblStudyPlanTitle.Size = new System.Drawing.Size(135, 32);
            this.lblStudyPlanTitle.TabIndex = 1;
            this.lblStudyPlanTitle.Text = "Study Plan";
            // 
            // lblPriorityQueueHeader
            // 
            this.lblPriorityQueueHeader.AutoSize = true;
            this.lblPriorityQueueHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPriorityQueueHeader.Location = new System.Drawing.Point(17, 206);
            this.lblPriorityQueueHeader.Name = "lblPriorityQueueHeader";
            this.lblPriorityQueueHeader.Size = new System.Drawing.Size(331, 28);
            this.lblPriorityQueueHeader.TabIndex = 2;
            this.lblPriorityQueueHeader.Text = "Priority Queue - most urgent first";
            // 
            // btnRefreshStudyPlan
            // 
            this.btnRefreshStudyPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.btnRefreshStudyPlan.FlatAppearance.BorderSize = 0;
            this.btnRefreshStudyPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStudyPlan.ForeColor = System.Drawing.Color.White;
            this.btnRefreshStudyPlan.Location = new System.Drawing.Point(750, 201);
            this.btnRefreshStudyPlan.Name = "btnRefreshStudyPlan";
            this.btnRefreshStudyPlan.Size = new System.Drawing.Size(120, 32);
            this.btnRefreshStudyPlan.TabIndex = 3;
            this.btnRefreshStudyPlan.Text = "Refresh";
            this.btnRefreshStudyPlan.UseVisualStyleBackColor = false;
            this.btnRefreshStudyPlan.Click += new System.EventHandler(this.btnRefreshStudyPlan_Click);
            // 
            // lstStudyPlan
            // 
            this.lstStudyPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStudyPlan.BackColor = System.Drawing.Color.White;
            this.lstStudyPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstStudyPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstStudyPlan.ItemHeight = 26;
            this.lstStudyPlan.Location = new System.Drawing.Point(17, 251);
            this.lstStudyPlan.Name = "lstStudyPlan";
            this.lstStudyPlan.Size = new System.Drawing.Size(974, 366);
            this.lstStudyPlan.TabIndex = 4;
            this.lstStudyPlan.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstStudyPlan_DrawItem);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // tbcStudy_And_Assignment_Tracker
            // 
            this.tbcStudy_And_Assignment_Tracker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcAdd_Remove_Modules);
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcAssignements);
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcStudySchedule);
            this.tbcStudy_And_Assignment_Tracker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tbcStudy_And_Assignment_Tracker.ItemSize = new System.Drawing.Size(180, 36);
            this.tbcStudy_And_Assignment_Tracker.Location = new System.Drawing.Point(8, 76);
            this.tbcStudy_And_Assignment_Tracker.Margin = new System.Windows.Forms.Padding(2);
            this.tbcStudy_And_Assignment_Tracker.Name = "tbcStudy_And_Assignment_Tracker";
            this.tbcStudy_And_Assignment_Tracker.SelectedIndex = 0;
            this.tbcStudy_And_Assignment_Tracker.Size = new System.Drawing.Size(1454, 1127);
            this.tbcStudy_And_Assignment_Tracker.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcStudy_And_Assignment_Tracker.TabIndex = 2;
            // 
            // tbcAdd_Remove_Modules
            // 
            this.tbcAdd_Remove_Modules.AutoScroll = true;
            this.tbcAdd_Remove_Modules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbcAdd_Remove_Modules.Controls.Add(this.pnlModulesAccent);
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpViewModuleDetails);
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpRemoveModule);
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpAddModules);
            this.tbcAdd_Remove_Modules.Location = new System.Drawing.Point(4, 40);
            this.tbcAdd_Remove_Modules.Margin = new System.Windows.Forms.Padding(2);
            this.tbcAdd_Remove_Modules.Name = "tbcAdd_Remove_Modules";
            this.tbcAdd_Remove_Modules.Padding = new System.Windows.Forms.Padding(2);
            this.tbcAdd_Remove_Modules.Size = new System.Drawing.Size(1446, 1083);
            this.tbcAdd_Remove_Modules.TabIndex = 0;
            this.tbcAdd_Remove_Modules.Text = "Modules";
            // 
            // pnlModulesAccent
            // 
            this.pnlModulesAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(112)))), ((int)(((byte)(190)))));
            this.pnlModulesAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlModulesAccent.Location = new System.Drawing.Point(2, 2);
            this.pnlModulesAccent.Name = "pnlModulesAccent";
            this.pnlModulesAccent.Size = new System.Drawing.Size(1442, 6);
            this.pnlModulesAccent.TabIndex = 10;
            // 
            // grpViewModuleDetails
            // 
            this.grpViewModuleDetails.BackColor = System.Drawing.Color.White;
            this.grpViewModuleDetails.Controls.Add(this.btnViewDetails);
            this.grpViewModuleDetails.Controls.Add(this.lstModules_ViewDetails);
            this.grpViewModuleDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(102)))));
            this.grpViewModuleDetails.Location = new System.Drawing.Point(18, 343);
            this.grpViewModuleDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpViewModuleDetails.Name = "grpViewModuleDetails";
            this.grpViewModuleDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpViewModuleDetails.Size = new System.Drawing.Size(527, 166);
            this.grpViewModuleDetails.TabIndex = 4;
            this.grpViewModuleDetails.TabStop = false;
            this.grpViewModuleDetails.Text = "View Module Details";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(265, 25);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(240, 51);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Module";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            // 
            // lstModules_ViewDetails
            // 
            this.lstModules_ViewDetails.FormattingEnabled = true;
            this.lstModules_ViewDetails.ItemHeight = 21;
            this.lstModules_ViewDetails.Location = new System.Drawing.Point(21, 25);
            this.lstModules_ViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.lstModules_ViewDetails.Name = "lstModules_ViewDetails";
            this.lstModules_ViewDetails.Size = new System.Drawing.Size(211, 109);
            this.lstModules_ViewDetails.TabIndex = 0;
            // 
            // grpRemoveModule
            // 
            this.grpRemoveModule.BackColor = System.Drawing.Color.White;
            this.grpRemoveModule.Controls.Add(this.btnRemoveModule);
            this.grpRemoveModule.Controls.Add(this.lstModules_remove);
            this.grpRemoveModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(102)))));
            this.grpRemoveModule.Location = new System.Drawing.Point(18, 144);
            this.grpRemoveModule.Margin = new System.Windows.Forms.Padding(2);
            this.grpRemoveModule.Name = "grpRemoveModule";
            this.grpRemoveModule.Padding = new System.Windows.Forms.Padding(2);
            this.grpRemoveModule.Size = new System.Drawing.Size(527, 166);
            this.grpRemoveModule.TabIndex = 3;
            this.grpRemoveModule.TabStop = false;
            this.grpRemoveModule.Text = "Remove Module";
            // 
            // btnRemoveModule
            // 
            this.btnRemoveModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.btnRemoveModule.FlatAppearance.BorderSize = 0;
            this.btnRemoveModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveModule.ForeColor = System.Drawing.Color.White;
            this.btnRemoveModule.Location = new System.Drawing.Point(265, 26);
            this.btnRemoveModule.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveModule.Name = "btnRemoveModule";
            this.btnRemoveModule.Size = new System.Drawing.Size(240, 43);
            this.btnRemoveModule.TabIndex = 1;
            this.btnRemoveModule.Text = "Remove Module";
            this.btnRemoveModule.UseVisualStyleBackColor = false;
            // 
            // lstModules_remove
            // 
            this.lstModules_remove.FormattingEnabled = true;
            this.lstModules_remove.ItemHeight = 21;
            this.lstModules_remove.Location = new System.Drawing.Point(21, 26);
            this.lstModules_remove.Margin = new System.Windows.Forms.Padding(2);
            this.lstModules_remove.Name = "lstModules_remove";
            this.lstModules_remove.Size = new System.Drawing.Size(223, 109);
            this.lstModules_remove.TabIndex = 0;
            // 
            // grpAddModules
            // 
            this.grpAddModules.BackColor = System.Drawing.Color.White;
            this.grpAddModules.Controls.Add(this.label1);
            this.grpAddModules.Controls.Add(this.btnAddModule);
            this.grpAddModules.Controls.Add(this.txtModules);
            this.grpAddModules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(102)))));
            this.grpAddModules.Location = new System.Drawing.Point(18, 17);
            this.grpAddModules.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddModules.Name = "grpAddModules";
            this.grpAddModules.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddModules.Size = new System.Drawing.Size(527, 102);
            this.grpAddModules.TabIndex = 2;
            this.grpAddModules.TabStop = false;
            this.grpAddModules.Text = "Add Modules";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your module code in the form of (ABCD1234)";
            // 
            // btnAddModule
            // 
            this.btnAddModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddModule.FlatAppearance.BorderSize = 0;
            this.btnAddModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModule.ForeColor = System.Drawing.Color.White;
            this.btnAddModule.Location = new System.Drawing.Point(265, 55);
            this.btnAddModule.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(240, 31);
            this.btnAddModule.TabIndex = 1;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = false;
            // 
            // txtModules
            // 
            this.txtModules.Location = new System.Drawing.Point(21, 55);
            this.txtModules.Margin = new System.Windows.Forms.Padding(2);
            this.txtModules.Name = "txtModules";
            this.txtModules.Size = new System.Drawing.Size(223, 29);
            this.txtModules.TabIndex = 0;
            // 
            // tbcAssignements
            // 
            this.tbcAssignements.AutoScroll = true;
            this.tbcAssignements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbcAssignements.Controls.Add(this.pnlAssignmentsAccent);
            this.tbcAssignements.Controls.Add(this.txtSearch);
            this.tbcAssignements.Controls.Add(this.btnSortAssignments);
            this.tbcAssignements.Controls.Add(this.btnDeleteAssignment);
            this.tbcAssignements.Controls.Add(this.btnViewAssignmentDetails);
            this.tbcAssignements.Controls.Add(this.btnSaveAndExit);
            this.tbcAssignements.Controls.Add(this.lblTotalAssignments);
            this.tbcAssignements.Controls.Add(this.lblOverdueAssignments);
            this.tbcAssignements.Controls.Add(this.lblModulesTracked);
            this.tbcAssignements.Controls.Add(this.txtModuleSummary);
            this.tbcAssignements.Controls.Add(this.btnGuide);
            this.tbcAssignements.Controls.Add(this.groupBox1);
            this.tbcAssignements.Controls.Add(this.grpEditAssignement);
            this.tbcAssignements.Controls.Add(this.grpAddAssignment);
            this.tbcAssignements.Location = new System.Drawing.Point(4, 40);
            this.tbcAssignements.Margin = new System.Windows.Forms.Padding(2);
            this.tbcAssignements.Name = "tbcAssignements";
            this.tbcAssignements.Padding = new System.Windows.Forms.Padding(2);
            this.tbcAssignements.Size = new System.Drawing.Size(1446, 1083);
            this.tbcAssignements.TabIndex = 1;
            this.tbcAssignements.Text = "Assignments";
            // 
            // pnlAssignmentsAccent
            // 
            this.pnlAssignmentsAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.pnlAssignmentsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssignmentsAccent.Location = new System.Drawing.Point(2, 2);
            this.pnlAssignmentsAccent.Name = "pnlAssignmentsAccent";
            this.pnlAssignmentsAccent.Size = new System.Drawing.Size(1442, 6);
            this.pnlAssignmentsAccent.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(17, 176);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 29);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search by module or keyword";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSortAssignments
            // 
            this.btnSortAssignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(76)))), ((int)(((byte)(175)))));
            this.btnSortAssignments.FlatAppearance.BorderSize = 0;
            this.btnSortAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAssignments.ForeColor = System.Drawing.Color.White;
            this.btnSortAssignments.Location = new System.Drawing.Point(390, 176);
            this.btnSortAssignments.Name = "btnSortAssignments";
            this.btnSortAssignments.Size = new System.Drawing.Size(210, 31);
            this.btnSortAssignments.TabIndex = 6;
            this.btnSortAssignments.Text = "Sort: DueDate (A-Z / earliest)";
            this.btnSortAssignments.UseVisualStyleBackColor = false;
            this.btnSortAssignments.Click += new System.EventHandler(this.btnSortAssignments_Click);
            // 
            // btnDeleteAssignment
            // 
            this.btnDeleteAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.btnDeleteAssignment.FlatAppearance.BorderSize = 0;
            this.btnDeleteAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssignment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAssignment.Location = new System.Drawing.Point(610, 176);
            this.btnDeleteAssignment.Name = "btnDeleteAssignment";
            this.btnDeleteAssignment.Size = new System.Drawing.Size(130, 31);
            this.btnDeleteAssignment.TabIndex = 7;
            this.btnDeleteAssignment.Text = "Delete";
            this.btnDeleteAssignment.UseVisualStyleBackColor = false;
            this.btnDeleteAssignment.Click += new System.EventHandler(this.btnDeleteAssignment_Click);
            // 
            // btnViewAssignmentDetails
            // 
            this.btnViewAssignmentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.btnViewAssignmentDetails.FlatAppearance.BorderSize = 0;
            this.btnViewAssignmentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAssignmentDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewAssignmentDetails.Location = new System.Drawing.Point(754, 176);
            this.btnViewAssignmentDetails.Name = "btnViewAssignmentDetails";
            this.btnViewAssignmentDetails.Size = new System.Drawing.Size(160, 31);
            this.btnViewAssignmentDetails.TabIndex = 8;
            this.btnViewAssignmentDetails.Text = "View Details";
            this.btnViewAssignmentDetails.UseVisualStyleBackColor = false;
            this.btnViewAssignmentDetails.Click += new System.EventHandler(this.btnViewAssignmentDetails_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAndExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnSaveAndExit.FlatAppearance.BorderSize = 0;
            this.btnSaveAndExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndExit.ForeColor = System.Drawing.Color.White;
            this.btnSaveAndExit.Location = new System.Drawing.Point(17, 1017);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(200, 35);
            this.btnSaveAndExit.TabIndex = 9;
            this.btnSaveAndExit.Text = "Save and exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = false;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // lblTotalAssignments
            // 
            this.lblTotalAssignments.AutoSize = true;
            this.lblTotalAssignments.Location = new System.Drawing.Point(1050, 223);
            this.lblTotalAssignments.Name = "lblTotalAssignments";
            this.lblTotalAssignments.Size = new System.Drawing.Size(172, 23);
            this.lblTotalAssignments.TabIndex = 10;
            this.lblTotalAssignments.Text = "Total assignments: 0";
            // 
            // lblOverdueAssignments
            // 
            this.lblOverdueAssignments.AutoSize = true;
            this.lblOverdueAssignments.Location = new System.Drawing.Point(1050, 250);
            this.lblOverdueAssignments.Name = "lblOverdueAssignments";
            this.lblOverdueAssignments.Size = new System.Drawing.Size(98, 23);
            this.lblOverdueAssignments.TabIndex = 11;
            this.lblOverdueAssignments.Text = "Overdue: 0";
            // 
            // lblModulesTracked
            // 
            this.lblModulesTracked.AutoSize = true;
            this.lblModulesTracked.Location = new System.Drawing.Point(1050, 277);
            this.lblModulesTracked.Name = "lblModulesTracked";
            this.lblModulesTracked.Size = new System.Drawing.Size(164, 23);
            this.lblModulesTracked.TabIndex = 12;
            this.lblModulesTracked.Text = "Modules tracked: 0";
            // 
            // txtModuleSummary
            // 
            this.txtModuleSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtModuleSummary.BackColor = System.Drawing.Color.White;
            this.txtModuleSummary.Location = new System.Drawing.Point(1050, 310);
            this.txtModuleSummary.Multiline = true;
            this.txtModuleSummary.Name = "txtModuleSummary";
            this.txtModuleSummary.ReadOnly = true;
            this.txtModuleSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtModuleSummary.Size = new System.Drawing.Size(330, 440);
            this.txtModuleSummary.TabIndex = 13;
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.ForeColor = System.Drawing.Color.White;
            this.btnGuide.Location = new System.Drawing.Point(1050, 12);
            this.btnGuide.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(330, 199);
            this.btnGuide.TabIndex = 4;
            this.btnGuide.Text = "Help / Guide";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnEditAssignment);
            this.groupBox1.Controls.Add(this.btnAssignments);
            this.groupBox1.Controls.Add(this.btnCompletedAssignment);
            this.groupBox1.Controls.Add(this.lstCurrentAssignments);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(102)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1013, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Assignments";
            // 
            // btnEditAssignment
            // 
            this.btnEditAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnEditAssignment.FlatAppearance.BorderSize = 0;
            this.btnEditAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAssignment.ForeColor = System.Drawing.Color.White;
            this.btnEditAssignment.Location = new System.Drawing.Point(19, 181);
            this.btnEditAssignment.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAssignment.Name = "btnEditAssignment";
            this.btnEditAssignment.Size = new System.Drawing.Size(177, 45);
            this.btnEditAssignment.TabIndex = 3;
            this.btnEditAssignment.Text = "Load for Editing";
            this.btnEditAssignment.UseVisualStyleBackColor = false;
            this.btnEditAssignment.Click += new System.EventHandler(this.btnEditAssignment_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(104)))), ((int)(((byte)(130)))));
            this.btnAssignments.FlatAppearance.BorderSize = 0;
            this.btnAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignments.ForeColor = System.Drawing.Color.White;
            this.btnAssignments.Location = new System.Drawing.Point(19, 103);
            this.btnAssignments.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(177, 56);
            this.btnAssignments.TabIndex = 2;
            this.btnAssignments.Text = "View Overdue Assignements";
            this.btnAssignments.UseVisualStyleBackColor = false;
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            // 
            // btnCompletedAssignment
            // 
            this.btnCompletedAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.btnCompletedAssignment.FlatAppearance.BorderSize = 0;
            this.btnCompletedAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletedAssignment.ForeColor = System.Drawing.Color.White;
            this.btnCompletedAssignment.Location = new System.Drawing.Point(19, 27);
            this.btnCompletedAssignment.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompletedAssignment.Name = "btnCompletedAssignment";
            this.btnCompletedAssignment.Size = new System.Drawing.Size(177, 58);
            this.btnCompletedAssignment.TabIndex = 1;
            this.btnCompletedAssignment.Text = "Completed Assignment";
            this.btnCompletedAssignment.UseVisualStyleBackColor = false;
            this.btnCompletedAssignment.Click += new System.EventHandler(this.btnCompletedAssignment_Click);
            // 
            // lstCurrentAssignments
            // 
            this.lstCurrentAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCurrentAssignments.BackColor = System.Drawing.Color.White;
            this.lstCurrentAssignments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCurrentAssignments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstCurrentAssignments.FormattingEnabled = true;
            this.lstCurrentAssignments.ItemHeight = 26;
            this.lstCurrentAssignments.Location = new System.Drawing.Point(264, 19);
            this.lstCurrentAssignments.Margin = new System.Windows.Forms.Padding(2);
            this.lstCurrentAssignments.Name = "lstCurrentAssignments";
            this.lstCurrentAssignments.Size = new System.Drawing.Size(730, 236);
            this.lstCurrentAssignments.TabIndex = 0;
            this.lstCurrentAssignments.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstCurrentAssignments_DrawItem);
            // 
            // grpEditAssignement
            // 
            this.grpEditAssignement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEditAssignement.BackColor = System.Drawing.Color.White;
            this.grpEditAssignement.Controls.Add(this.txtAssignment_edit);
            this.grpEditAssignement.Controls.Add(this.label5);
            this.grpEditAssignement.Controls.Add(this.btnAssignment_edit);
            this.grpEditAssignement.Controls.Add(this.dateTimePicker1);
            this.grpEditAssignement.Controls.Add(this.label4);
            this.grpEditAssignement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(102)))));
            this.grpEditAssignement.Location = new System.Drawing.Point(17, 531);
            this.grpEditAssignement.Margin = new System.Windows.Forms.Padding(2);
            this.grpEditAssignement.Name = "grpEditAssignement";
            this.grpEditAssignement.Padding = new System.Windows.Forms.Padding(2);
            this.grpEditAssignement.Size = new System.Drawing.Size(1013, 235);
            this.grpEditAssignement.TabIndex = 1;
            this.grpEditAssignement.TabStop = false;
            this.grpEditAssignement.Text = "Edit Selected Assignment";
            // 
            // txtAssignment_edit
            // 
            this.txtAssignment_edit.Location = new System.Drawing.Point(373, 63);
            this.txtAssignment_edit.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssignment_edit.Name = "txtAssignment_edit";
            this.txtAssignment_edit.Size = new System.Drawing.Size(295, 29);
            this.txtAssignment_edit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(370, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assignment Name";
            // 
            // btnAssignment_edit
            // 
            this.btnAssignment_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnAssignment_edit.FlatAppearance.BorderSize = 0;
            this.btnAssignment_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignment_edit.ForeColor = System.Drawing.Color.White;
            this.btnAssignment_edit.Location = new System.Drawing.Point(19, 97);
            this.btnAssignment_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignment_edit.Name = "btnAssignment_edit";
            this.btnAssignment_edit.Size = new System.Drawing.Size(256, 30);
            this.btnAssignment_edit.TabIndex = 5;
            this.btnAssignment_edit.Text = "Save Changes";
            this.btnAssignment_edit.UseVisualStyleBackColor = false;
            this.btnAssignment_edit.Click += new System.EventHandler(this.btnAssignment_edit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Assignment due date";
            // 
            // grpAddAssignment
            // 
            this.grpAddAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddAssignment.BackColor = System.Drawing.Color.White;
            this.grpAddAssignment.Controls.Add(this.lblModuleSelect);
            this.grpAddAssignment.Controls.Add(this.cmbAssignmentModule);
            this.grpAddAssignment.Controls.Add(this.btnAssignment_add);
            this.grpAddAssignment.Controls.Add(this.label3);
            this.grpAddAssignment.Controls.Add(this.txtAssignmentName_Add);
            this.grpAddAssignment.Controls.Add(this.label2);
            this.grpAddAssignment.Controls.Add(this.dtpDueDate_add);
            this.grpAddAssignment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(102)))));
            this.grpAddAssignment.Location = new System.Drawing.Point(17, 12);
            this.grpAddAssignment.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddAssignment.Name = "grpAddAssignment";
            this.grpAddAssignment.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddAssignment.Size = new System.Drawing.Size(1013, 152);
            this.grpAddAssignment.TabIndex = 0;
            this.grpAddAssignment.TabStop = false;
            this.grpAddAssignment.Text = "Add / Edit Assignment";
            // 
            // lblModuleSelect
            // 
            this.lblModuleSelect.AutoSize = true;
            this.lblModuleSelect.ForeColor = System.Drawing.Color.Black;
            this.lblModuleSelect.Location = new System.Drawing.Point(700, 31);
            this.lblModuleSelect.Name = "lblModuleSelect";
            this.lblModuleSelect.Size = new System.Drawing.Size(71, 23);
            this.lblModuleSelect.TabIndex = 5;
            this.lblModuleSelect.Text = "Module";
            // 
            // cmbAssignmentModule
            // 
            this.cmbAssignmentModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignmentModule.FormattingEnabled = true;
            this.cmbAssignmentModule.Location = new System.Drawing.Point(700, 55);
            this.cmbAssignmentModule.Name = "cmbAssignmentModule";
            this.cmbAssignmentModule.Size = new System.Drawing.Size(260, 29);
            this.cmbAssignmentModule.TabIndex = 6;
            // 
            // btnAssignment_add
            // 
            this.btnAssignment_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAssignment_add.FlatAppearance.BorderSize = 0;
            this.btnAssignment_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignment_add.ForeColor = System.Drawing.Color.White;
            this.btnAssignment_add.Location = new System.Drawing.Point(19, 102);
            this.btnAssignment_add.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignment_add.Name = "btnAssignment_add";
            this.btnAssignment_add.Size = new System.Drawing.Size(256, 30);
            this.btnAssignment_add.TabIndex = 4;
            this.btnAssignment_add.Text = "Add Assignment";
            this.btnAssignment_add.UseVisualStyleBackColor = false;
            this.btnAssignment_add.Click += new System.EventHandler(this.btnAssignment_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(370, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assignment Name";
            // 
            // txtAssignmentName_Add
            // 
            this.txtAssignmentName_Add.Location = new System.Drawing.Point(373, 55);
            this.txtAssignmentName_Add.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssignmentName_Add.Name = "txtAssignmentName_Add";
            this.txtAssignmentName_Add.Size = new System.Drawing.Size(295, 29);
            this.txtAssignmentName_Add.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignment due date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpDueDate_add
            // 
            this.dtpDueDate_add.Location = new System.Drawing.Point(19, 55);
            this.dtpDueDate_add.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDueDate_add.Name = "dtpDueDate_add";
            this.dtpDueDate_add.Size = new System.Drawing.Size(257, 29);
            this.dtpDueDate_add.TabIndex = 0;
            // 
            // tbcStudySchedule
            // 
            this.tbcStudySchedule.AutoScroll = true;
            this.tbcStudySchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbcStudySchedule.Controls.Add(this.pnlScheduleAccent);
            this.tbcStudySchedule.Controls.Add(this.lblStudyPlanTitle);
            this.tbcStudySchedule.Controls.Add(this.pnlCountdownHero);
            this.tbcStudySchedule.Controls.Add(this.lblPriorityQueueHeader);
            this.tbcStudySchedule.Controls.Add(this.btnRefreshStudyPlan);
            this.tbcStudySchedule.Controls.Add(this.lstStudyPlan);
            this.tbcStudySchedule.Location = new System.Drawing.Point(4, 40);
            this.tbcStudySchedule.Margin = new System.Windows.Forms.Padding(2);
            this.tbcStudySchedule.Name = "tbcStudySchedule";
            this.tbcStudySchedule.Padding = new System.Windows.Forms.Padding(2);
            this.tbcStudySchedule.Size = new System.Drawing.Size(1446, 1083);
            this.tbcStudySchedule.TabIndex = 2;
            this.tbcStudySchedule.Text = "Study Plan";
            // 
            // pnlScheduleAccent
            // 
            this.pnlScheduleAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.pnlScheduleAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlScheduleAccent.Location = new System.Drawing.Point(2, 2);
            this.pnlScheduleAccent.Name = "pnlScheduleAccent";
            this.pnlScheduleAccent.Size = new System.Drawing.Size(1442, 6);
            this.pnlScheduleAccent.TabIndex = 30;
            // 
            // frmStudyAndAssignement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1470, 1055);
            this.Controls.Add(this.tbcStudy_And_Assignment_Tracker);
            this.Controls.Add(this.pnlHeroHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "frmStudyAndAssignement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study And Assignment Tracker";
            this.pnlHeroHeader.ResumeLayout(false);
            this.pnlHeroHeader.PerformLayout();
            this.pnlCountdownHero.ResumeLayout(false);
            this.pnlCountdownHero.PerformLayout();
            this.tbcStudy_And_Assignment_Tracker.ResumeLayout(false);
            this.tbcAdd_Remove_Modules.ResumeLayout(false);
            this.grpViewModuleDetails.ResumeLayout(false);
            this.grpRemoveModule.ResumeLayout(false);
            this.grpAddModules.ResumeLayout(false);
            this.grpAddModules.PerformLayout();
            this.tbcAssignements.ResumeLayout(false);
            this.tbcAssignements.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpEditAssignement.ResumeLayout(false);
            this.grpEditAssignement.PerformLayout();
            this.grpAddAssignment.ResumeLayout(false);
            this.grpAddAssignment.PerformLayout();
            this.tbcStudySchedule.ResumeLayout(false);
            this.tbcStudySchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeroHeader;
        private System.Windows.Forms.Label lblHeroTitle;
        private System.Windows.Forms.Panel pnlCountdownHero;
        private System.Windows.Forms.Label lblCountdownCaption;
        private System.Windows.Forms.Label lblCountdownTitle;
        private System.Windows.Forms.Label lblCountdownTime;
        private System.Windows.Forms.Label lblStudyPlanTitle;
        private System.Windows.Forms.Label lblPriorityQueueHeader;
        private System.Windows.Forms.Button btnRefreshStudyPlan;
        private System.Windows.Forms.ListBox lstStudyPlan;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.TabControl tbcStudy_And_Assignment_Tracker;
        private System.Windows.Forms.TabPage tbcAdd_Remove_Modules;
        private System.Windows.Forms.Panel pnlModulesAccent;
        private System.Windows.Forms.GroupBox grpViewModuleDetails;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.ListBox lstModules_ViewDetails;
        private System.Windows.Forms.GroupBox grpRemoveModule;
        private System.Windows.Forms.Button btnRemoveModule;
        private System.Windows.Forms.ListBox lstModules_remove;
        private System.Windows.Forms.GroupBox grpAddModules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.TextBox txtModules;
        private System.Windows.Forms.TabPage tbcAssignements;
        private System.Windows.Forms.Panel pnlAssignmentsAccent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSortAssignments;
        private System.Windows.Forms.Button btnDeleteAssignment;
        private System.Windows.Forms.Button btnViewAssignmentDetails;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Label lblTotalAssignments;
        private System.Windows.Forms.Label lblOverdueAssignments;
        private System.Windows.Forms.Label lblModulesTracked;
        private System.Windows.Forms.TextBox txtModuleSummary;
        private System.Windows.Forms.GroupBox grpAddAssignment;
        private System.Windows.Forms.TabPage tbcStudySchedule;
        private System.Windows.Forms.Panel pnlScheduleAccent;
        private System.Windows.Forms.Label lblModuleSelect;
        private System.Windows.Forms.ComboBox cmbAssignmentModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDueDate_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssignmentName_Add;
        private System.Windows.Forms.GroupBox grpEditAssignement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssignment_add;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditAssignment;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnCompletedAssignment;
        private System.Windows.Forms.ListBox lstCurrentAssignments;
        private System.Windows.Forms.TextBox txtAssignment_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAssignment_edit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
