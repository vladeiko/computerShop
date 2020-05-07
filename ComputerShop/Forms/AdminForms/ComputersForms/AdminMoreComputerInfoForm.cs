using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;

namespace ComputerShop
{
    public partial class AdminMoreComputerInfoForm : Form
    {
        public int compId;

        public AdminMoreComputerInfoForm(int id)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            compId = id;

            using(var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                Computer toShow = db.Computers.SingleOrDefault(c => c.Id == compId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                manufacturerTextBox.Text = toShow.Manufacturer;
                modelTextBox.Text = toShow.Model;
                priceUpDown.Value = (decimal)toShow.Price;
                imagePictureBox.ImageLocation = toShow.ImagePath;

                processorComboBox.DataSource = db.Processors.ToList();
                numOfCoresTextBox.Text = toShow.Processor.NumOfCores.ToString();
                mhzTextBox.Text = toShow.Processor.ClockFrequency.ToString();

                videocardComboBox.DataSource = db.Videocards.ToList();
                videomemoryTextBox.Text = toShow.Videocard.VideoMemory.ToString();

                ramComboBox.DataSource = db.RAMs.ToList();
                ramSizeTextBox.Text = toShow.RAM.Size.ToString();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            acceptButton.Visible = true;
            declineButton.Visible = true;
            editButton.Visible = false;
            addPictureButton.Visible = true;

            manufacturerTextBox.ReadOnly = false;
            modelTextBox.ReadOnly = false;
            processorComboBox.Enabled = true;
            videocardComboBox.Enabled = true;
            ramComboBox.Enabled = true;
            priceUpDown.ReadOnly = false;
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            using(var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                Computer toShow = db.Computers.SingleOrDefault(c => c.Id == compId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                manufacturerTextBox.Text = toShow.Manufacturer;
                modelTextBox.Text = toShow.Model;
                priceUpDown.Value = (decimal)toShow.Price;
                imagePictureBox.ImageLocation = toShow.ImagePath;

                numOfCoresTextBox.Text = toShow.Processor.NumOfCores.ToString();
                mhzTextBox.Text = toShow.Processor.ClockFrequency.ToString();

                videomemoryTextBox.Text = toShow.Videocard.VideoMemory.ToString();

                ramSizeTextBox.Text = toShow.RAM.Size.ToString();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;
            addPictureButton.Visible = false;

            manufacturerTextBox.ReadOnly = true;
            modelTextBox.ReadOnly = true;
            processorComboBox.Enabled = false;
            videocardComboBox.Enabled = false;
            ramComboBox.Enabled = false;
            priceUpDown.ReadOnly = true;

            return;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            using(var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                Computer editing = db.Computers.SingleOrDefault(c => c.Id == compId);

                if(manufacturerTextBox.Text == "")
                {
                    // TODO: add error
                }

                if(modelTextBox.Text == "")
                {
                    // TODO: add error
                }

                editing.Manufacturer = manufacturerTextBox.Text;
                editing.Model = modelTextBox.Text;
                editing.ProcessorId = ((Processor)processorComboBox.SelectedItem).Id;
                editing.VideocardId = ((Videocard)videocardComboBox.SelectedItem).Id;
                editing.RAMId = ((RAM)ramComboBox.SelectedItem).Id;
                editing.Price = (float)priceUpDown.Value;
                editing.ImagePath = imagePictureBox.ImageLocation;

                db.SaveChanges();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;
            addPictureButton.Visible = false;

            manufacturerTextBox.ReadOnly = true;
            modelTextBox.ReadOnly = true;
            processorComboBox.Enabled = false;
            videocardComboBox.Enabled = false;
            ramComboBox.Enabled = false;
            priceUpDown.ReadOnly = true;

            return;
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            imagePictureBox.ImageLocation = openFileDialog1.FileName;
        }

        private void PrintImg(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(imagePictureBox.Width, imagePictureBox.Height);

            imagePictureBox.DrawToBitmap(bm, new Rectangle(0, 0, imagePictureBox.Width, imagePictureBox.Height));

            e.Graphics.DrawImage(bm, 0, 0);

            bm.Dispose();

        }

        private void printImageButton_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();

            PrintDocument doc = new PrintDocument();

            doc.PrintPage += PrintImg;

            pd.Document = doc;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
    }
}
