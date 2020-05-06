using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class acceptDeleteComp : Form
    {
        public int compId;
        
        public acceptDeleteComp()
        {
            InitializeComponent();
        }

        public acceptDeleteComp(int id)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            compId = id;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                Computer toDelete = db.Computers.SingleOrDefault(p => p.Id == compId);

                if (toDelete == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                db.Computers.Remove(toDelete);
                db.SaveChanges();
            }

            this.Close();

            return;
        }
    }
}
