using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            using(MyDbContext db = new MyDbContext())
            {
                string login = LoginTextBox.Text;
                string password = PasswordTextBox.Text;

                // Authorization procession. Is "login" registered?
                User authorising = db.Users.SingleOrDefault(u => u.Login == login);

                // Error processing. Wrong password
                if (authorising == null || !PasswordHasher.Verify(password, authorising.PassWord))
                {
                    // TODO:
                    // Add error (wrong password or username)
                    return;
                }

                // Authorization processing
                if (authorising.Status == "admin")
                {
                    CurrentUser.Set(authorising);

                    AdminForm1 form = new AdminForm1();
                    form.Show();
                    Hide();
                }

                if (authorising.Status == "user")
                {
                    CurrentUser.Set(authorising);

                    UserForm1 form = new UserForm1();
                    form.Show();
                    Hide();
                }
            }
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            GuestForm1 form = new GuestForm1();
            form.Show();
            Hide();
        }
    }
}
