﻿using System;
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
                string stringVideomemory = videomemoryTextBox.Text;
                int videomemory;

                // Eror processing. If string is not a num - return
                try
                {
                    videomemory = Convert.ToInt32(stringVideomemory);
                }
                catch
                {
                    return;
                }

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
