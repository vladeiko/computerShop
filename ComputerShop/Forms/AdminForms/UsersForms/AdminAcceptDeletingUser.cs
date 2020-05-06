using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminAcceptDeletingUser : Form
    {
        public int userId;
        public AdminAcceptDeletingUser()
        {
            InitializeComponent();
        }

        public AdminAcceptDeletingUser(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            userId = id;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                User toDelete = db.Users.SingleOrDefault(u => u.Id == userId);

                if (toDelete == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                db.Users.Remove(toDelete);
                db.SaveChanges();
            }

            this.Close();

            return;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
