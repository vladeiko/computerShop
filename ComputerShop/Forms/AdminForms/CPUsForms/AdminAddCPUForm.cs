using System;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminAddCPUForm : Form
    {
        public AdminAddCPUForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string procname = procNameTextBox.Text;
                string numofcores = numOfCoresTextBox.Text;
                string clockfrequency = clockFrequencyTextBox.Text;

                // Error processing
                try
                {
                    Convert.ToInt32(numofcores);
                }
                catch
                {
                    return;
                }

                // Error processing
                try
                {
                    Convert.ToInt32(clockfrequency);
                }
                catch
                {
                    return;
                }

                if (procname == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                if (numofcores == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                if (clockfrequency == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                var newProc = new Processor()
                {
                    Name = procname,
                    NumOfCores = Convert.ToInt32(numofcores),
                    ClockFrequency = Convert.ToInt32(clockfrequency)
                };

                db.Processors.Add(newProc);
                db.SaveChanges();
            }

            this.Close();

            return;
        }
    }
}
