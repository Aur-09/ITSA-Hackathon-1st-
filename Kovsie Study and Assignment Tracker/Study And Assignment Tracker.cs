using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kovsie_Study_and_Assignment_Tracker
{
    public partial class frmStudyAndAssignement : Form
    {
        public frmStudyAndAssignement()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Add Assignment section\n\t" +
                "- Add Assignment button: Adds new assignment\n" +
                "- Current Assignement section\n\t" +
                "- Assignment Completed: Flag the selected an assignments as completed\n\t" +
                "- Overdue Assignements: Shows the overdue assignments in the list box\n\t" +
                "- Edit Assignments: Open the edit assignment section to allow you to edit your assignments\n"+
                "- Edit Assignment section\n\t" +
                "- Edit Assignments: Save the changes you have made"
                , "Guide for assignements tab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
