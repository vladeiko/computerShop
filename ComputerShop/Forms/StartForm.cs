using System;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            Hide();
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            Hide();
        }
    }
}
