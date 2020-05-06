using System;
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
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

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
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                Computer newComputer = new Computer()
                {
                    Manufacturer = manufacturerTextBox.Text,
                    Model = modelTextBox.Text,
                    ProcessorId = ((Processor)processorComboBox.SelectedItem).Id,
                    VideocardId = ((Videocard)videocardComboBox.SelectedItem).Id,
                    RAMId = ((RAM)ramComboBox.SelectedItem).Id,
                    Price = (float)priceUpDown.Value,
                    ImagePath = imagePictureBox.ImageLocation
                };

                db.Computers.Add(newComputer);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
