using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;

namespace ComputerShop
{
    public partial class AdminAddComputerForm : Form
    {
        public AdminAddComputerForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            using(var db = new MyDbContext())
            {
                processorComboBox.DataSource = db.Processors.ToList();

                videocardComboBox.DataSource = db.Videocards.ToList();

                ramComboBox.DataSource = db.RAMs.ToList();
            }
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            imagePictureBox.ImageLocation = openFileDialog1.FileName;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using(var db = new MyDbContext())
            {
                Computer newComputer = new Computer()
                {
                    Manufacturer = manufacturerTextBox.Text,
                    Model = modelTextBox.Text,
                    ProcessorId = ((Processor)processorComboBox.SelectedItem).Id,
                    VideocardId = ((Videocard)videocardComboBox.SelectedItem).Id,
                    RAMId = ((RAM)ramComboBox.SelectedItem).Id,
                    Price = (float)priceUpDown.Value
                };

                db.Computers.Add(newComputer);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
