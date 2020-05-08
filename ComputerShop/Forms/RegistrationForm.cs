using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            loginErrorLabel.Visible = false;
            nameErrorLabel.Visible = false;
            secnameErrorLabel.Visible = false;
            passwordErrorLabel.Visible = false;
            emailErrorLabel.Visible = false;
            phoneErrorLabel.Visible = false;
            rulesNotAcceptedLabel.Visible = false;
            regErrorLabel.Visible = false;

            using (var db = new MyDbContext())
            {
                string login = LoginTextBox.Text;
                string firstName = FirstNameTextBox.Text;
                string secondName = SecondNameTextBox.Text;
                string passWord = PassWordTextBox.Text;
                string email = EmailTextBox.Text;
                string phone = PhoneTextBox.Text;
                string imgPath = avatarPictureBox.ImageLocation;

                bool allowReg = true;

                if (avatarPictureBox.ImageLocation == "")
                {
                    imgPath = "D:\\Univer\\4sem\\practice\\computerShop\\ComputerShop\\img\\noAvatar.png";
                }

                // Error processing. Incorrectly entered data
                Regex regexLogin = new Regex(".{3,}");  
                if (!regexLogin.IsMatch(login))
                {
                    loginErrorLabel.Visible = true;

                    return;
                }

                // Error processing. Incorrectly entered data
                Regex regexFN = new Regex(".[А-я]");
                if (!regexFN.IsMatch(firstName))
                {
                    nameErrorLabel.Visible = true;

                    return;
                }

                // Error processing. Incorrectly entered data
                Regex regexSN = new Regex(".[А-я]");
                if (!regexSN.IsMatch(secondName))
                {
                    secnameErrorLabel.Visible = true;

                    return;
                }

                // Error processing. Incorrectly entered data
                Regex regexPassword = new Regex(".{10,}");
                if (!regexPassword.IsMatch(passWord))
                {
                    passwordErrorLabel.Visible = true;

                    return;
                }

                // Error processing. Incorrectly entered data
                Regex regexEmail = new Regex(".[a-zA-Z@a-zA-Z.a-zA-Z]+");
                if (!regexEmail.IsMatch(email))
                {
                    emailErrorLabel.Visible = true;

                    return;
                }

                // Error processing. Incorrectly entered data
                Regex regexPhone = new Regex(".[0-9]");
                Regex regexPhone2 = new Regex(".{10,}");
                if (!regexPhone.IsMatch(phone) || !regexPhone2.IsMatch(phone))
                {
                    phoneErrorLabel.Visible = true;

                    return;
                }

                // Error processing. Is there such a user?
                User registration = db.Users.SingleOrDefault(u => u.Login == login);

                if (registration != null)
                {
                    regErrorLabel.Visible = true;
                    return;
                }
                
                // Error processing. Is rules accepted?
                if(acceptCheckBox.Checked == false)
                {
                    rulesNotAcceptedLabel.Visible = true;
                    return;
                }

                // Registration processing. Registration allowed
                if(registration == null && acceptCheckBox.Checked == true && allowReg == true)
                {
                    // Create new User var and add it to DataBase, then save DataBase
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
