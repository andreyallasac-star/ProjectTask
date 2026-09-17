using System;
using System.Windows.Forms;

namespace ProjectTask
{
    public partial class MDIParentForm : Form
    {
        public MDIParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enrollmentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnrollment enrollForm = new frmEnrollment();
            enrollForm.MdiParent = this;
            enrollForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentView enrollForm = new frmStudentView();
            enrollForm.MdiParent = this;
            enrollForm.Show();
        }

        private void enrollmentFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEnrollment enrollForm = new frmEnrollment();
            enrollForm.MdiParent = this;
            enrollForm.Show();
        }
    }
}
