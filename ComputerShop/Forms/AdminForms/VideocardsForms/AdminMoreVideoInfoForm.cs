using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminMoreVideoInfoForm : Form
    {
        public int videoId;

        public AdminMoreVideoInfoForm()
        {
            InitializeComponent();
        }

        public AdminMoreVideoInfoForm(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            videoId = id;

            using (var db = new MyDbContext())
            {
                Videocard toShow = db.Videocards.SingleOrDefault(v => v.Id == videoId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                videoNameTextBox.Text = toShow.Name;
                videomemoryTextBox.Text = toShow.VideoMemory.ToString();
            }

            return;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            acceptButton.Visible = true;
            declineButton.Visible = true;
            editButton.Visible = false;

            videoNameTextBox.ReadOnly = false;
            videomemoryTextBox.ReadOnly = false;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string videoName = videoNameTextBox.Text;
                string videomemory = videomemoryTextBox.Text;

                // Eror processing. If string is not a num - return
                try
                {
                    Convert.ToInt32(videomemory);
                }
                catch
                {
                    return;
                }

                Videocard editing = db.Videocards.SingleOrDefault(v => v.Id == videoId);

                if (videoName == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                if (videomemory == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                editing.Name = videoName;
                editing.VideoMemory = Convert.ToInt32(videomemory);

                db.SaveChanges();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;

            videoNameTextBox.ReadOnly = true;
            videomemoryTextBox.ReadOnly = true;

            return;
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                Videocard toShow = db.Videocards.SingleOrDefault(v => v.Id == videoId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                videoNameTextBox.Text = toShow.Name;
                videomemoryTextBox.Text = toShow.VideoMemory.ToString();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;

            videoNameTextBox.ReadOnly = true;
            videomemoryTextBox.ReadOnly = true;

            return;
        }
    }
}
