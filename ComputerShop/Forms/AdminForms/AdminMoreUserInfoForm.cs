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
        public AdminMoreUserInfoForm()
        {
            InitializeComponent();
        }

        public AdminMoreUserInfoForm(int id)
        {
            InitializeComponent();

            using(var db = new MyDbContext())
            {
                User toShow = db.Users.SingleOrDefault(u => u.Id == id);

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
    }
}
