using System;
using System.Windows.Forms;

namespace ComputerShop.Forms.AdminForms.ComputersForms
{
    public partial class AdminAddComputerForm : Form
    {
        public AdminAddComputerForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void addPictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            imagePictureBox.ImageLocation = openFileDialog1.FileName;
        }
    }
}
