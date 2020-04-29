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

                User authorising = new User();
                bool loginStatus = false;

                foreach(var u in db.Users)
                {
                    if (login == u.Login && password == u.PassWord)
                    {
                        loginStatus = true;
                        authorising = u;
                    }
                }

                if(loginStatus == false)
                {
                    // Add error message
                }

                if(authorising.Status == "admin" && loginStatus == true)
                {
                    AdminForm1 form = new AdminForm1();
                    form.Show();
                    Hide();
                }

                if (authorising.Status == "user" && loginStatus == true)
                {
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
