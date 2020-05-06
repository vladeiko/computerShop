using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminAcceptDeletingRam : Form
    {
        public int ramId;

        public AdminAcceptDeletingRam()
        {
            InitializeComponent();
        }

        public AdminAcceptDeletingRam(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            ramId = id;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                RAM toDelete = db.RAMs.SingleOrDefault(r => r.Id == ramId);

                if (toDelete == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                db.RAMs.Remove(toDelete);
                db.SaveChanges();
            }

            this.Close();

            return;
        }
    }
}
