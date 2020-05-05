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
    public partial class AdminAddUserForm : Form
    {
        public AdminAddUserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string login = loginTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string secondName = secondNameTextBox.Text;
                string passWord = passwordTextBox.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                string status = statusComboBox.Text;
                string imgPath = avatarPictureBox.ImageLocation;

                if (avatarPictureBox.ImageLocation == null)
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

                // Registration processing. Registration allowed
                if (registration == null)
                {
                    var newUser = new User()
                    {
                        Login = login,
                        FirstName = firstName,
                        SecondName = secondName,
                        PassWord = PasswordHasher.Hash(passWord),
                        Email = email,
                        Phone = phone,
                        Status = status,
                        ImagePath = imgPath
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
            }

            this.Close();

            return;
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            avatarPictureBox.ImageLocation = openFileDialog1.FileName;
        }
    }
}
