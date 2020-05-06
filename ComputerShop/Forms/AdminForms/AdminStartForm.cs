using System;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminStartForm : Form
    {
        public AdminStartForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminStartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showUsersButton_Click(object sender, EventArgs e)
        {
            AdminShowUsersForm form = new AdminShowUsersForm();
            form.Show();
            Hide();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            Hide();
        }

        private void showProcessorsButton_Click(object sender, EventArgs e)
        {
            AdminShowCPUsForm form = new AdminShowCPUsForm();
            form.Show();
            Hide();
        }

        private void showVideocardsButton_Click(object sender, EventArgs e)
        {
            AdminShowVideocardsForm form = new AdminShowVideocardsForm();
            form.Show();
            Hide();
        }

        private void showRAMsButton_Click(object sender, EventArgs e)
        {
            AdminShowRAMsForm form = new AdminShowRAMsForm();
            form.Show();
            Hide();
        }

        private void showComputersButton_Click(object sender, EventArgs e)
        {
            AdminShowComputersForm form = new AdminShowComputersForm();
            form.Show();
            Hide();
        }
    }
}
