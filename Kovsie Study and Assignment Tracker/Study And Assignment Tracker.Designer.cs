
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
            this.tbcStudy_And_Assignment_Tracker.SuspendLayout();
            this.tbcAdd_Remove_Modules.SuspendLayout();
            this.grpViewModuleDetails.SuspendLayout();
            this.grpRemoveModule.SuspendLayout();
            this.grpAddModules.SuspendLayout();
            this.tbcAssignements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpEditAssignement.SuspendLayout();
            this.grpAddAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcStudy_And_Assignment_Tracker
            // 
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcAdd_Remove_Modules);
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcAssignements);
            this.tbcStudy_And_Assignment_Tracker.Controls.Add(this.tbcStudySchedule);
            this.tbcStudy_And_Assignment_Tracker.Location = new System.Drawing.Point(8, 8);
            this.tbcStudy_And_Assignment_Tracker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcStudy_And_Assignment_Tracker.Name = "tbcStudy_And_Assignment_Tracker";
            this.tbcStudy_And_Assignment_Tracker.SelectedIndex = 0;
            this.tbcStudy_And_Assignment_Tracker.Size = new System.Drawing.Size(1004, 720);
            this.tbcStudy_And_Assignment_Tracker.TabIndex = 2;
            // 
            // tbcAdd_Remove_Modules
            // 
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpViewModuleDetails);
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpRemoveModule);
            this.tbcAdd_Remove_Modules.Controls.Add(this.grpAddModules);
            this.tbcAdd_Remove_Modules.Location = new System.Drawing.Point(4, 25);
            this.tbcAdd_Remove_Modules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcAdd_Remove_Modules.Name = "tbcAdd_Remove_Modules";
            this.tbcAdd_Remove_Modules.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcAdd_Remove_Modules.Size = new System.Drawing.Size(996, 691);
            this.tbcAdd_Remove_Modules.TabIndex = 0;
            this.tbcAdd_Remove_Modules.Text = "Add Modules";
            this.tbcAdd_Remove_Modules.UseVisualStyleBackColor = true;
            // 
            // grpViewModuleDetails
            // 
            this.grpViewModuleDetails.Controls.Add(this.btnViewDetails);
            this.grpViewModuleDetails.Controls.Add(this.lstModules_ViewDetails);
            this.grpViewModuleDetails.Location = new System.Drawing.Point(18, 343);
            this.grpViewModuleDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpViewModuleDetails.Name = "grpViewModuleDetails";
            this.grpViewModuleDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpViewModuleDetails.Size = new System.Drawing.Size(527, 166);
            this.grpViewModuleDetails.TabIndex = 4;
            this.grpViewModuleDetails.TabStop = false;
            this.grpViewModuleDetails.Text = "View Module Details";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(265, 25);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(240, 51);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Module";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // lstModules_ViewDetails
            // 
            this.lstModules_ViewDetails.FormattingEnabled = true;
            this.lstModules_ViewDetails.ItemHeight = 16;
            this.lstModules_ViewDetails.Location = new System.Drawing.Point(21, 25);
            this.lstModules_ViewDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstModules_ViewDetails.Name = "lstModules_ViewDetails";
            this.lstModules_ViewDetails.Size = new System.Drawing.Size(211, 116);
            this.lstModules_ViewDetails.TabIndex = 0;
            // 
            // grpRemoveModule
            // 
            this.grpRemoveModule.Controls.Add(this.btnRemoveModule);
            this.grpRemoveModule.Controls.Add(this.lstModules_remove);
            this.grpRemoveModule.Location = new System.Drawing.Point(18, 144);
            this.grpRemoveModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRemoveModule.Name = "grpRemoveModule";
            this.grpRemoveModule.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRemoveModule.Size = new System.Drawing.Size(527, 166);
            this.grpRemoveModule.TabIndex = 3;
            this.grpRemoveModule.TabStop = false;
            this.grpRemoveModule.Text = "Remove Module";
            // 
            // btnRemoveModule
            // 
            this.btnRemoveModule.Location = new System.Drawing.Point(265, 26);
            this.btnRemoveModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveModule.Name = "btnRemoveModule";
            this.btnRemoveModule.Size = new System.Drawing.Size(240, 43);
            this.btnRemoveModule.TabIndex = 1;
            this.btnRemoveModule.Text = "Remove Module";
            this.btnRemoveModule.UseVisualStyleBackColor = true;
            // 
            // lstModules_remove
            // 
            this.lstModules_remove.FormattingEnabled = true;
            this.lstModules_remove.ItemHeight = 16;
            this.lstModules_remove.Location = new System.Drawing.Point(21, 26);
            this.lstModules_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstModules_remove.Name = "lstModules_remove";
            this.lstModules_remove.Size = new System.Drawing.Size(223, 116);
            this.lstModules_remove.TabIndex = 0;
            // 
            // grpAddModules
            // 
            this.grpAddModules.Controls.Add(this.label1);
            this.grpAddModules.Controls.Add(this.btnAddModule);
            this.grpAddModules.Controls.Add(this.txtModules);
            this.grpAddModules.Location = new System.Drawing.Point(18, 17);
            this.grpAddModules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddModules.Name = "grpAddModules";
            this.grpAddModules.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddModules.Size = new System.Drawing.Size(527, 102);
            this.grpAddModules.TabIndex = 2;
            this.grpAddModules.TabStop = false;
            this.grpAddModules.Text = "Add Modules";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your module code in the form of (ABCD1234)";
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(265, 55);
            this.btnAddModule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(240, 31);
            this.btnAddModule.TabIndex = 1;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            // 
            // txtModules
            // 
            this.txtModules.Location = new System.Drawing.Point(21, 55);
            this.txtModules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModules.Name = "txtModules";
            this.txtModules.Size = new System.Drawing.Size(223, 22);
            this.txtModules.TabIndex = 0;
            // 
            // tbcAssignements
            // 
            this.tbcAssignements.Controls.Add(this.btnGuide);
            this.tbcAssignements.Controls.Add(this.groupBox1);
            this.tbcAssignements.Controls.Add(this.grpEditAssignement);
            this.tbcAssignements.Controls.Add(this.grpAddAssignment);
            this.tbcAssignements.Location = new System.Drawing.Point(4, 25);
            this.tbcAssignements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcAssignements.Name = "tbcAssignements";
            this.tbcAssignements.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcAssignements.Size = new System.Drawing.Size(996, 691);
            this.tbcAssignements.TabIndex = 1;
            this.tbcAssignements.Text = "Assignments";
            this.tbcAssignements.UseVisualStyleBackColor = true;
            // 
            // btnGuide
            // 
            this.btnGuide.Location = new System.Drawing.Point(717, 22);
            this.btnGuide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(208, 637);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 173);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(675, 337);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Assignments";
            // 
            // btnEditAssignment
            // 
            this.btnEditAssignment.Location = new System.Drawing.Point(19, 189);
            this.btnEditAssignment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditAssignment.Name = "btnEditAssignment";
            this.btnEditAssignment.Size = new System.Drawing.Size(177, 45);
            this.btnEditAssignment.TabIndex = 3;
            this.btnEditAssignment.Text = "Edit Assignment";
            this.btnEditAssignment.UseVisualStyleBackColor = true;
            // 
            // btnAssignments
            // 
            this.btnAssignments.Location = new System.Drawing.Point(19, 103);
            this.btnAssignments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(177, 42);
            this.btnAssignments.TabIndex = 2;
            this.btnAssignments.Text = "View Overdue Assignements";
            this.btnAssignments.UseVisualStyleBackColor = true;
            // 
            // btnCompletedAssignment
            // 
            this.btnCompletedAssignment.Location = new System.Drawing.Point(19, 27);
            this.btnCompletedAssignment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompletedAssignment.Name = "btnCompletedAssignment";
            this.btnCompletedAssignment.Size = new System.Drawing.Size(177, 42);
            this.btnCompletedAssignment.TabIndex = 1;
            this.btnCompletedAssignment.Text = "Assignment Completed";
            this.btnCompletedAssignment.UseVisualStyleBackColor = true;
            // 
            // lstCurrentAssignments
            // 
            this.lstCurrentAssignments.FormattingEnabled = true;
            this.lstCurrentAssignments.ItemHeight = 16;
            this.lstCurrentAssignments.Location = new System.Drawing.Point(264, 19);
            this.lstCurrentAssignments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCurrentAssignments.Name = "lstCurrentAssignments";
            this.lstCurrentAssignments.Size = new System.Drawing.Size(399, 308);
            this.lstCurrentAssignments.TabIndex = 0;
            // 
            // grpEditAssignement
            // 
            this.grpEditAssignement.Controls.Add(this.txtAssignment_edit);
            this.grpEditAssignement.Controls.Add(this.label5);
            this.grpEditAssignement.Controls.Add(this.btnAssignment_edit);
            this.grpEditAssignement.Controls.Add(this.dateTimePicker1);
            this.grpEditAssignement.Controls.Add(this.label4);
            this.grpEditAssignement.Location = new System.Drawing.Point(11, 515);
            this.grpEditAssignement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEditAssignement.Name = "grpEditAssignement";
            this.grpEditAssignement.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEditAssignement.Size = new System.Drawing.Size(675, 150);
            this.grpEditAssignement.TabIndex = 1;
            this.grpEditAssignement.TabStop = false;
            this.grpEditAssignement.Text = "Edit Assignment";
            // 
            // txtAssignment_edit
            // 
            this.txtAssignment_edit.Location = new System.Drawing.Point(373, 63);
            this.txtAssignment_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssignment_edit.Name = "txtAssignment_edit";
            this.txtAssignment_edit.Size = new System.Drawing.Size(295, 22);
            this.txtAssignment_edit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assignment Name";
            // 
            // btnAssignment_edit
            // 
            this.btnAssignment_edit.Location = new System.Drawing.Point(19, 97);
            this.btnAssignment_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignment_edit.Name = "btnAssignment_edit";
            this.btnAssignment_edit.Size = new System.Drawing.Size(256, 30);
            this.btnAssignment_edit.TabIndex = 5;
            this.btnAssignment_edit.Text = "Edit Assignment";
            this.btnAssignment_edit.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
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
            this.grpAddAssignment.Location = new System.Drawing.Point(11, 12);
            this.grpAddAssignment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddAssignment.Name = "grpAddAssignment";
            this.grpAddAssignment.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddAssignment.Size = new System.Drawing.Size(675, 152);
            this.grpAddAssignment.TabIndex = 0;
            this.grpAddAssignment.TabStop = false;
            this.grpAddAssignment.Text = "Add Assignment";
            // 
            // btnAssignment_add
            // 
            this.btnAssignment_add.Location = new System.Drawing.Point(19, 102);
            this.btnAssignment_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignment_add.Name = "btnAssignment_add";
            this.btnAssignment_add.Size = new System.Drawing.Size(256, 30);
            this.btnAssignment_add.TabIndex = 4;
            this.btnAssignment_add.Text = "Add Assignment";
            this.btnAssignment_add.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assignment Name";
            // 
            // txtAssignmentName_Add
            // 
            this.txtAssignmentName_Add.Location = new System.Drawing.Point(373, 55);
            this.txtAssignmentName_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssignmentName_Add.Name = "txtAssignmentName_Add";
            this.txtAssignmentName_Add.Size = new System.Drawing.Size(295, 22);
            this.txtAssignmentName_Add.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignment due date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpDueDate_add
            // 
            this.dtpDueDate_add.Location = new System.Drawing.Point(19, 55);
            this.dtpDueDate_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDueDate_add.Name = "dtpDueDate_add";
            this.dtpDueDate_add.Size = new System.Drawing.Size(257, 22);
            this.dtpDueDate_add.TabIndex = 0;
            // 
            // tbcStudySchedule
            // 
            this.tbcStudySchedule.Location = new System.Drawing.Point(4, 25);
            this.tbcStudySchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcStudySchedule.Name = "tbcStudySchedule";
            this.tbcStudySchedule.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcStudySchedule.Size = new System.Drawing.Size(996, 691);
            this.tbcStudySchedule.TabIndex = 2;
            this.tbcStudySchedule.Text = "Study schedule";
            this.tbcStudySchedule.UseVisualStyleBackColor = true;
            // 
            // frmStudyAndAssignement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 675);
            this.Controls.Add(this.tbcStudy_And_Assignment_Tracker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

