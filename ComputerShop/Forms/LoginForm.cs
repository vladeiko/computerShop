using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            authorisationErrorLabel.Visible = false;
            progressBar1.Visible = true;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
                Thread.Sleep(10);
            }

            using (MyDbContext db = new MyDbContext())
            {
                string login = LoginTextBox.Text;
                string password = PasswordTextBox.Text;

                // Authorization procession. Is user registered?
                User authorising = db.Users.SingleOrDefault(u => u.Login == login);

                // Error processing. Wrong password or login
                if (authorising == null || !PasswordHasher.Verify(password, authorising.PassWord))
                {
                    authorisationErrorLabel.Visible = true;

                    progressBar1.Visible = false;

                    return;
                }

                // Authorization processing
                if (authorising.Status == "admin")
                {
                    CurrentUser.Set(authorising);

                    AdminStartForm form = new AdminStartForm();
                    form.Show();

                    progressBar1.Visible = false;

                    Hide();
                }

                // Authorization processing
                if (authorising.Status == "user")
                {
                    CurrentUser.Set(authorising);

                    UserStartForm form = new UserStartForm();
                    form.Show();

                    progressBar1.Visible = false;

                    Hide();
                }
            }

            return;
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            GuestStartForm form = new GuestStartForm();
            form.Show();
            Hide();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
