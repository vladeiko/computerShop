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
    public partial class AdminAddRamForm : Form
    {
        public AdminAddRamForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string ramName = ramNameTextBox.Text;
                int size = Convert.ToInt32(sizeTextBox.Text);

                if (ramName == "")
                {
                    // TODO:
                    // Add error
                }

                if (sizeTextBox.Text == null)
                {
                    // TODO:
                    // Add error
                }

                var newRam = new RAM()
                {
                    Name = ramName,
                    Size = size
                };

                db.RAMs.Add(newRam);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
