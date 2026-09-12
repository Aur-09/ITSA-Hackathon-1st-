
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
            this.tbcStudy_And_Assignment_Tracker = new System.Windows.Forms.TabControl();
            this.tbcAdd_Remove_Modules = new System.Windows.Forms.TabPage();
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
            this.btnAssignment_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssignmentName_Add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDueDate_add = new System.Windows.Forms.DateTimePicker();
            this.tbcStudySchedule = new System.Windows.Forms.TabPage();
            this.dgvWeeklyCalendar = new System.Windows.Forms.DataGridView();
            this.clm_monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Thurday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcStudy_And_Assignment_Tracker
            // 
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcAdd_Remove_Modules);
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcAssignements);
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcStudySchedule);
            this.tbcStudy_And_Assignment_Tracker.Location = new System.Drawing.Point(12, 12);
            this.tbcStudy_And_Assignment_Tracker.Name = "tbcStudy_And_Assignment_Tracker";
            this.tbcStudy_And_Assignment_Tracker.SelectedIndex = 0;
            this.tbcStudy_And_Assignment_Tracker.Size = new System.Drawing.Size(1506, 1125);
            this.tbcStudy_And_Assignment_Tracker.TabIndex = 2;
            // 
            // tbcAdd_Remove_Modules
            // 
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpViewModuleDetails);
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpRemoveModule);
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpAddModules);
            this.tbcAdd_Remove_Modules.Location = new System.Drawing.Point(8, 39);
            this.tbcAdd_Remove_Modules.Name = "tbcAdd_Remove_Modules";
            this.tbcAdd_Remove_Modules.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAdd_Remove_Modules.Size = new System.Drawing.Size(1465, 1078);
            this.tbcAdd_Remove_Modules.TabIndex = 0;
            this.tbcAdd_Remove_Modules.Text = "Add Modules";
            this.tbcAdd_Remove_Modules.UseVisualStyleBackColor = true;
            // 
            // grpViewModuleDetails
            // 
            this.grpViewModuleDetails.Controls.Add(this.btnViewDetails);
            this.grpViewModuleDetails.Controls.Add(this.lstModules_ViewDetails);
            this.grpViewModuleDetails.Location = new System.Drawing.Point(27, 536);
            this.grpViewModuleDetails.Name = "grpViewModuleDetails";
            this.grpViewModuleDetails.Size = new System.Drawing.Size(790, 260);
            this.grpViewModuleDetails.TabIndex = 4;
            this.grpViewModuleDetails.TabStop = false;
            this.grpViewModuleDetails.Text = "View Module Details";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(397, 39);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(360, 79);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Module";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // lstModules_ViewDetails
            // 
            this.lstModules_ViewDetails.FormattingEnabled = true;
            this.lstModules_ViewDetails.ItemHeight = 25;
            this.lstModules_ViewDetails.Location = new System.Drawing.Point(31, 39);
            this.lstModules_ViewDetails.Name = "lstModules_ViewDetails";
            this.lstModules_ViewDetails.Size = new System.Drawing.Size(315, 179);
            this.lstModules_ViewDetails.TabIndex = 0;
            // 
            // grpRemoveModule
            // 
            this.grpRemoveModule.Controls.Add(this.btnRemoveModule);
            this.grpRemoveModule.Controls.Add(this.lstModules_remove);
            this.grpRemoveModule.Location = new System.Drawing.Point(27, 225);
            this.grpRemoveModule.Name = "grpRemoveModule";
            this.grpRemoveModule.Size = new System.Drawing.Size(790, 259);
            this.grpRemoveModule.TabIndex = 3;
            this.grpRemoveModule.TabStop = false;
            this.grpRemoveModule.Text = "Remove Module";
            // 
            // btnRemoveModule
            // 
            this.btnRemoveModule.Location = new System.Drawing.Point(397, 41);
            this.btnRemoveModule.Name = "btnRemoveModule";
            this.btnRemoveModule.Size = new System.Drawing.Size(360, 67);
            this.btnRemoveModule.TabIndex = 1;
            this.btnRemoveModule.Text = "Remove Module";
            this.btnRemoveModule.UseVisualStyleBackColor = true;
            // 
            // lstModules_remove
            // 
            this.lstModules_remove.FormattingEnabled = true;
            this.lstModules_remove.ItemHeight = 25;
            this.lstModules_remove.Location = new System.Drawing.Point(31, 41);
            this.lstModules_remove.Name = "lstModules_remove";
            this.lstModules_remove.Size = new System.Drawing.Size(332, 179);
            this.lstModules_remove.TabIndex = 0;
            // 
            // grpAddModules
            // 
            this.grpAddModules.Controls.Add(this.label1);
            this.grpAddModules.Controls.Add(this.btnAddModule);
            this.grpAddModules.Controls.Add(this.txtModules);
            this.grpAddModules.Location = new System.Drawing.Point(27, 26);
            this.grpAddModules.Name = "grpAddModules";
            this.grpAddModules.Size = new System.Drawing.Size(790, 159);
            this.grpAddModules.TabIndex = 2;
            this.grpAddModules.TabStop = false;
            this.grpAddModules.Text = "Add Modules";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your module code in the form of (ABCD1234)";
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(397, 86);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(360, 48);
            this.btnAddModule.TabIndex = 1;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            // 
            // txtModules
            // 
            this.txtModules.Location = new System.Drawing.Point(31, 86);
            this.txtModules.Name = "txtModules";
            this.txtModules.Size = new System.Drawing.Size(332, 31);
            this.txtModules.TabIndex = 0;
            // 
            // tbcAssignements
            // 
            this.tbcAssignements.Controls.Add(this.btnGuide);
            this.tbcAssignements.Controls.Add(this.groupBox1);
            this.tbcAssignements.Controls.Add(this.grpEditAssignement);
            this.tbcAssignements.Controls.Add(this.grpAddAssignment);
            this.tbcAssignements.Location = new System.Drawing.Point(8, 39);
            this.tbcAssignements.Name = "tbcAssignements";
            this.tbcAssignements.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAssignements.Size = new System.Drawing.Size(1465, 1078);
            this.tbcAssignements.TabIndex = 1;
            this.tbcAssignements.Text = "Assignments";
            this.tbcAssignements.UseVisualStyleBackColor = true;
            // 
            // btnGuide
            // 
            this.btnGuide.Location = new System.Drawing.Point(1076, 35);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(312, 995);
            this.btnGuide.TabIndex = 4;
            this.btnGuide.Text = "View Assignments Guide";
            this.btnGuide.UseVisualStyleBackColor = true;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditAssignment);
            this.groupBox1.Controls.Add(this.btnAssignments);
            this.groupBox1.Controls.Add(this.btnCompletedAssignment);
            this.groupBox1.Controls.Add(this.lstCurrentAssignments);
            this.groupBox1.Location = new System.Drawing.Point(17, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 527);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Assignments";
            // 
            // btnEditAssignment
            // 
            this.btnEditAssignment.Location = new System.Drawing.Point(28, 295);
            this.btnEditAssignment.Name = "btnEditAssignment";
            this.btnEditAssignment.Size = new System.Drawing.Size(265, 70);
            this.btnEditAssignment.TabIndex = 3;
            this.btnEditAssignment.Text = "Edit Assignment";
            this.btnEditAssignment.UseVisualStyleBackColor = true;
            // 
            // btnAssignments
            // 
            this.btnAssignments.Location = new System.Drawing.Point(28, 161);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(265, 65);
            this.btnAssignments.TabIndex = 2;
            this.btnAssignments.Text = "View Overdue Assignements";
            this.btnAssignments.UseVisualStyleBackColor = true;
            // 
            // btnCompletedAssignment
            // 
            this.btnCompletedAssignment.Location = new System.Drawing.Point(28, 42);
            this.btnCompletedAssignment.Name = "btnCompletedAssignment";
            this.btnCompletedAssignment.Size = new System.Drawing.Size(265, 66);
            this.btnCompletedAssignment.TabIndex = 1;
            this.btnCompletedAssignment.Text = "Assignment Completed";
            this.btnCompletedAssignment.UseVisualStyleBackColor = true;
            // 
            // lstCurrentAssignments
            // 
            this.lstCurrentAssignments.FormattingEnabled = true;
            this.lstCurrentAssignments.ItemHeight = 25;
            this.lstCurrentAssignments.Location = new System.Drawing.Point(396, 30);
            this.lstCurrentAssignments.Name = "lstCurrentAssignments";
            this.lstCurrentAssignments.Size = new System.Drawing.Size(596, 479);
            this.lstCurrentAssignments.TabIndex = 0;
            // 
            // grpEditAssignement
            // 
            this.grpEditAssignement.Controls.Add(this.txtAssignment_edit);
            this.grpEditAssignement.Controls.Add(this.label5);
            this.grpEditAssignement.Controls.Add(this.btnAssignment_edit);
            this.grpEditAssignement.Controls.Add(this.dateTimePicker1);
            this.grpEditAssignement.Controls.Add(this.label4);
            this.grpEditAssignement.Location = new System.Drawing.Point(17, 804);
            this.grpEditAssignement.Name = "grpEditAssignement";
            this.grpEditAssignement.Size = new System.Drawing.Size(1013, 235);
            this.grpEditAssignement.TabIndex = 1;
            this.grpEditAssignement.TabStop = false;
            this.grpEditAssignement.Text = "Edit Assignment";
            // 
            // txtAssignment_edit
            // 
            this.txtAssignment_edit.Location = new System.Drawing.Point(560, 98);
            this.txtAssignment_edit.Name = "txtAssignment_edit";
            this.txtAssignment_edit.Size = new System.Drawing.Size(441, 31);
            this.txtAssignment_edit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assignment Name";
            // 
            // btnAssignment_edit
            // 
            this.btnAssignment_edit.Location = new System.Drawing.Point(28, 151);
            this.btnAssignment_edit.Name = "btnAssignment_edit";
            this.btnAssignment_edit.Size = new System.Drawing.Size(384, 47);
            this.btnAssignment_edit.TabIndex = 5;
            this.btnAssignment_edit.Text = "Edit Assignment";
            this.btnAssignment_edit.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(384, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Assignment due date";
            // 
            // grpAddAssignment
            // 
            this.grpAddAssignment.Controls.Add(this.btnAssignment_add);
            this.grpAddAssignment.Controls.Add(this.label3);
            this.grpAddAssignment.Controls.Add(this.txtAssignmentName_Add);
            this.grpAddAssignment.Controls.Add(this.label2);
            this.grpAddAssignment.Controls.Add(this.dtpDueDate_add);
            this.grpAddAssignment.Location = new System.Drawing.Point(17, 18);
            this.grpAddAssignment.Name = "grpAddAssignment";
            this.grpAddAssignment.Size = new System.Drawing.Size(1013, 237);
            this.grpAddAssignment.TabIndex = 0;
            this.grpAddAssignment.TabStop = false;
            this.grpAddAssignment.Text = "Add Assignment";
            // 
            // btnAssignment_add
            // 
            this.btnAssignment_add.Location = new System.Drawing.Point(28, 160);
            this.btnAssignment_add.Name = "btnAssignment_add";
            this.btnAssignment_add.Size = new System.Drawing.Size(384, 47);
            this.btnAssignment_add.TabIndex = 4;
            this.btnAssignment_add.Text = "Add Assignment";
            this.btnAssignment_add.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assignment Name";
            // 
            // txtAssignmentName_Add
            // 
            this.txtAssignmentName_Add.Location = new System.Drawing.Point(560, 86);
            this.txtAssignmentName_Add.Name = "txtAssignmentName_Add";
            this.txtAssignmentName_Add.Size = new System.Drawing.Size(441, 31);
            this.txtAssignmentName_Add.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignment due date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpDueDate_add
            // 
            this.dtpDueDate_add.Location = new System.Drawing.Point(28, 86);
            this.dtpDueDate_add.Name = "dtpDueDate_add";
            this.dtpDueDate_add.Size = new System.Drawing.Size(384, 31);
            this.dtpDueDate_add.TabIndex = 0;
            // 
            // tbcStudySchedule
            // 
            this.tbcStudySchedule.Controls.Add(this.dgvWeeklyCalendar);
            this.tbcStudySchedule.Location = new System.Drawing.Point(8, 39);
            this.tbcStudySchedule.Name = "tbcStudySchedule";
            this.tbcStudySchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tbcStudySchedule.Size = new System.Drawing.Size(1490, 1078);
            this.tbcStudySchedule.TabIndex = 2;
            this.tbcStudySchedule.Text = "Study schedule";
            this.tbcStudySchedule.UseVisualStyleBackColor = true;
            // 
            // dgvWeeklyCalendar
            // 
            this.dgvWeeklyCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_monday,
            this.clm_Tuesday,
            this.clm_Wednesday,
            this.clm_Thurday,
            this.clm_Friday,
            this.clm_Saturday,
            this.clm_Sunday});
            this.dgvWeeklyCalendar.Location = new System.Drawing.Point(6, 6);
            this.dgvWeeklyCalendar.Name = "dgvWeeklyCalendar";
            this.dgvWeeklyCalendar.RowHeadersWidth = 82;
            this.dgvWeeklyCalendar.RowTemplate.Height = 33;
            this.dgvWeeklyCalendar.Size = new System.Drawing.Size(1478, 514);
            this.dgvWeeklyCalendar.TabIndex = 0;
            // 
            // clm_monday
            // 
            this.clm_monday.HeaderText = "Monday";
            this.clm_monday.MinimumWidth = 10;
            this.clm_monday.Name = "clm_monday";
            this.clm_monday.Width = 200;
            // 
            // clm_Tuesday
            // 
            this.clm_Tuesday.HeaderText = "Tuesday";
            this.clm_Tuesday.MinimumWidth = 10;
            this.clm_Tuesday.Name = "clm_Tuesday";
            this.clm_Tuesday.Width = 200;
            // 
            // clm_Wednesday
            // 
            this.clm_Wednesday.HeaderText = "Wednesday";
            this.clm_Wednesday.MinimumWidth = 10;
            this.clm_Wednesday.Name = "clm_Wednesday";
            this.clm_Wednesday.Width = 200;
            // 
            // clm_Thurday
            // 
            this.clm_Thurday.HeaderText = "Thursday";
            this.clm_Thurday.MinimumWidth = 10;
            this.clm_Thurday.Name = "clm_Thurday";
            this.clm_Thurday.Width = 200;
            // 
            // clm_Friday
            // 
            this.clm_Friday.HeaderText = "Friday";
            this.clm_Friday.MinimumWidth = 10;
            this.clm_Friday.Name = "clm_Friday";
            this.clm_Friday.Width = 200;
            // 
            // clm_Saturday
            // 
            this.clm_Saturday.HeaderText = "Saturday";
            this.clm_Saturday.MinimumWidth = 10;
            this.clm_Saturday.Name = "clm_Saturday";
            this.clm_Saturday.Width = 200;
            // 
            // clm_Sunday
            // 
            this.clm_Sunday.HeaderText = "Sunday";
            this.clm_Sunday.MinimumWidth = 10;
            this.clm_Sunday.Name = "clm_Sunday";
            this.clm_Sunday.Width = 200;
            // 
            // frmStudyAndAssignement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 1173);
            this.Controls.Add(this.tbcStudy_And_Assignment_Tracker);
            this.Name = "frmStudyAndAssignement";
            this.Text = "Study And Assignment Tracker";
            this.tbcStudy_And_Assignment_Tracker.ResumeLayout(false);
            this.tbcAdd_Remove_Modules.ResumeLayout(false);
            this.grpViewModuleDetails.ResumeLayout(false);
            this.grpRemoveModule.ResumeLayout(false);
            this.grpAddModules.ResumeLayout(false);
            this.grpAddModules.PerformLayout();
            this.tbcAssignements.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpEditAssignement.ResumeLayout(false);
            this.grpEditAssignement.PerformLayout();
            this.grpAddAssignment.ResumeLayout(false);
            this.grpAddAssignment.PerformLayout();
            this.tbcStudySchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcStudy_And_Assignment_Tracker;
        private System.Windows.Forms.TabPage tbcAdd_Remove_Modules;
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
        private System.Windows.Forms.GroupBox grpAddAssignment;
        private System.Windows.Forms.TabPage tbcStudySchedule;
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
        private System.Windows.Forms.DataGridView dgvWeeklyCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Thurday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Sunday;
    }
}

