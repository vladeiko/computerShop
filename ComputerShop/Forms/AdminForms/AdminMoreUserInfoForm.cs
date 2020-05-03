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
    public partial class AdminMoreUserInfoForm : Form
    {
        public int userId;

        public AdminMoreUserInfoForm()
        {
            InitializeComponent();
        }

        public AdminMoreUserInfoForm(int id)
        {
            InitializeComponent();

            userId = id;

            using(var db = new MyDbContext())
            {
                User toShow = db.Users.SingleOrDefault(u => u.Id == userId);

                if(toShow == null)
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
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            acceptButton.Visible = true;
            declineButton.Visible = true;
            editButton.Visible = false;

            loginTextBox.ReadOnly = false;
            firstNameTextBox.ReadOnly = false;
            secondNameTextBox.ReadOnly = false;
            phoneTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
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

                User editing = db.Users.SingleOrDefault(u => u.Id == userId);

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

                db.SaveChanges();
            }


            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                User toShow = db.Users.SingleOrDefault(u => u.Id == userId);

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

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;
        }
    }
}
