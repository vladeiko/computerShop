using System;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class UserBuyForm : Form
    {
        public UserBuyForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            User now = CurrentUser.Get();

            emailTextBox.Text = now.Email;
            phoneTextBox.Text = now.Phone;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
