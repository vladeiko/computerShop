using System;
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
                int size;

                // Error processing
                try
                {
                    size = Convert.ToInt32(sizeTextBox.Text);
                }
                catch
                {
                    return;
                }

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
