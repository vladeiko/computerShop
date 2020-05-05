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
    public partial class AdminMoreCPUInfoForm : Form
    {
        public int cpuId;
        public AdminMoreCPUInfoForm()
        {
            InitializeComponent();
        }

        public AdminMoreCPUInfoForm(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            cpuId = id;

            using(var db = new MyDbContext())
            {
                Processor toShow = db.Processors.SingleOrDefault(p => p.Id == cpuId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                procNameTextBox.Text = toShow.Name;
                numOfCoresTextBox.Text = toShow.NumOfCores.ToString();
                clockFrequencyTextBox.Text = toShow.ClockFrequency.ToString();
            }

            return;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            acceptButton.Visible = true;
            declineButton.Visible = true;
            editButton.Visible = false;

            procNameTextBox.ReadOnly = false;
            numOfCoresTextBox.ReadOnly = false;
            clockFrequencyTextBox.ReadOnly = false;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string procname = procNameTextBox.Text;
                string numofcores = numOfCoresTextBox.Text;
                string clockfrequency = clockFrequencyTextBox.Text;

                Processor editing = db.Processors.SingleOrDefault(u => u.Id == cpuId);

                if (procname == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                if(numofcores == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                if(clockfrequency == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                editing.Name = procname;
                editing.NumOfCores = Convert.ToInt32(numofcores);
                editing.ClockFrequency = Convert.ToInt32(clockfrequency);

                db.SaveChanges();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;

            procNameTextBox.ReadOnly = true;
            numOfCoresTextBox.ReadOnly = true;
            clockFrequencyTextBox.ReadOnly = true;

            return;
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            using(var db = new MyDbContext())
            {
                Processor toShow = db.Processors.SingleOrDefault(u => u.Id == cpuId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                procNameTextBox.Text = toShow.Name;
                numOfCoresTextBox.Text = toShow.NumOfCores.ToString();
                clockFrequencyTextBox.Text = toShow.ClockFrequency.ToString();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;

            procNameTextBox.ReadOnly = true;
            numOfCoresTextBox.ReadOnly = true;
            clockFrequencyTextBox.ReadOnly = true;

            return;
        }
    }
}
