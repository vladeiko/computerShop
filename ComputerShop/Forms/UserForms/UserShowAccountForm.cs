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
    public partial class UserShowAccountForm : Form
    {
        public UserShowAccountForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            using (var db = new MyDbContext())
            {
                User toShow = CurrentUser.Get();

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                loginTextBox.Text = toShow.Login;
                firstNameTextBox.Text = toShow.FirstName;
                secondNameTextBox.Text = toShow.SecondName;
                phoneTextBox.Text = toShow.Phone;
                emailTextBox.Text = toShow.Email;
                avatarPictureBox.ImageLocation = toShow.ImagePath;
            }

            return;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string login = loginTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string secondName = secondNameTextBox.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                string imgPath = avatarPictureBox.ImageLocation;

                if (avatarPictureBox.ImageLocation == "")
                    imgPath = "D:\\Univer\\4sem\\practice\\computerShop\\ComputerShop\\img\\noAvatar.png";

                User editing = CurrentUser.Get();

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

                editing.Login = login;
                editing.FirstName = firstName;
                editing.SecondName = secondName;
                editing.Email = email;
                editing.Phone = phone;
                editing.ImagePath = imgPath;

                db.SaveChanges();
            }

            loginTextBox.ReadOnly = true;
            firstNameTextBox.ReadOnly = true;
            secondNameTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;
            addPictureButton.Visible = false;

            return;
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                User toShow = CurrentUser.Get();

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                loginTextBox.Text = toShow.Login;
                firstNameTextBox.Text = toShow.FirstName;
                secondNameTextBox.Text = toShow.SecondName;
                phoneTextBox.Text = toShow.Phone;
                emailTextBox.Text = toShow.Email;
            }

            loginTextBox.ReadOnly = true;
            firstNameTextBox.ReadOnly = true;
            secondNameTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;
            addPictureButton.Visible = false;

            return;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            acceptButton.Visible = true;
            declineButton.Visible = true;
            editButton.Visible = false;
            addPictureButton.Visible = true;

            loginTextBox.ReadOnly = false;
            firstNameTextBox.ReadOnly = false;
            secondNameTextBox.ReadOnly = false;
            phoneTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
        }
    }
}
