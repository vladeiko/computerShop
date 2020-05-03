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
                string email = EmailTextBox.Text;
                string phone = PhoneTextBox.Text;
                string imgPath = avatarPictureBox.ImageLocation;

                if (avatarPictureBox.ImageLocation == "")
                    imgPath = "D:\\Univer\\4sem\\practice\\computerShop\\ComputerShop\\img\\noAvatar.png"; 

                // Error processing. Incorrectly entered data
                if (login == "")
                    {
                        // TODO:
                        // Add empty login
                        return;
                    }

                    if (firstName == "")
                    {
                        // TODO:
                        // Add empty firstName
                        return;
                    }

                    if (secondName == "")
                    {
                        // TODO:
                        // Add empty secondName
                        return;
                    }

                    if (passWord == "")
                    {
                        // TODO:
                        // Add empty passWord
                        return;
                    }

                    if (email == "")
                    {
                        // TODO:
                        // Add empty email
                        return;
                    }

                    if (phone == "")
                    {
                        // TODO:
                        // Add empty phone
                        return;
                    }

                // Error processing. Is there such a user?
                User registration = db.Users.SingleOrDefault(u => u.Login == login);

                if (registration != null)
                {
                    // TODO:
                    // Add "wrong login" error message
                    return;
                }
                
                if(acceptCheckBox.Checked == false)
                {
                    // TODO:
                    // Add "not accepted checkbox" error message
                    return;
                }

                // Registration processing. Registration allowed
                if(registration == null && acceptCheckBox.Checked == true)
                {
                    var newUser = new User()
                    {
                        Login = login,
                        FirstName = firstName,
                        SecondName = secondName,
                        PassWord = PasswordHasher.Hash(passWord),
                        Email = email,
                        Phone = phone,
                        Status = "user",
                        ImagePath = imgPath
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    StartForm form = new StartForm();
                    form.Show();
                    Hide();
                }
            }

            return;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            Hide();
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            avatarPictureBox.ImageLocation = openFileDialog1.FileName;
        }
    }
}
