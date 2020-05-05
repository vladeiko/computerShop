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
    public partial class AdminAcceptDeletingProc : Form
    {
        public int cpuID;
        public AdminAcceptDeletingProc()
        {
            InitializeComponent();
        }

        public AdminAcceptDeletingProc(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            cpuID = id;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                Processor toDelete = db.Processors.SingleOrDefault(p => p.Id == cpuID);

                if (toDelete == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                db.Processors.Remove(toDelete);
                db.SaveChanges();
            }

            this.Close();

            return;
        }
    }
}
