using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminAcceptDeletingVideo : Form
    {
        public int videoId;
        public AdminAcceptDeletingVideo()
        {
            InitializeComponent();
        }

        public AdminAcceptDeletingVideo(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            videoId = id;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                Videocard toDelete = db.Videocards.SingleOrDefault(v => v.Id == videoId);

                if (toDelete == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                db.Videocards.Remove(toDelete);
                db.SaveChanges();
            }

            this.Close();

            return;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
