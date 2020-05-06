using System;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminAddVideocardForm : Form
    {
        public AdminAddVideocardForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using(var db = new MyDbContext())
            {
                string videocardName = videoNameTextBox.Text;
                int videomemory = Convert.ToInt32(videomemoryTextBox.Text);

                if (videocardName == "")
                {
                    // TODO:
                    // Add error
                }

                if (videomemoryTextBox.Text == null)
                {
                    // TODO:
                    // Add error
                }

                var newVideocard = new Videocard()
                {
                    Name = videocardName,
                    VideoMemory = videomemory
                };

                db.Videocards.Add(newVideocard);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
