using System;
using System.Windows.Forms;

namespace ProjectTask
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authentication login = new Authentication(txtUsername.Text, txtPassword.Text);

            bool isValid = login.Authenticate();
            if (isValid)
            {
                MDIParentForm mdi = new MDIParentForm();
                mdi.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
