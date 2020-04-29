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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string login = LoginTextBox.Text;
                string firstName = FirstNameTextBox.Text;
                string secondName = SecondNameTextBox.Text;
                string passWord = PassWordTextBox.Text;

                bool wrongLogin = false;

                foreach (var u in db.Users)
                {
                    if(login == u.Login)
                    {
                        wrongLogin = true;
                    }
                }

                if (wrongLogin == true)
                {
                    // Add "wrong login" error message
                }
                
                if(acceptCheckBox.Checked == false)
                {
                    // Add "not accepted checkbox" error message
                }

                if(wrongLogin == false && acceptCheckBox.Checked == true)
                {
                    var newUser = new User()
                    {
                        Login = login,
                        FirstName = firstName,
                        SecondName = secondName,
                        PassWord = passWord,
                        Status = "user"
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    StartForm form = new StartForm();
                    form.Show();
                    Hide();
                }
            }
        }
    }
}
