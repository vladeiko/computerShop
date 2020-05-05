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
