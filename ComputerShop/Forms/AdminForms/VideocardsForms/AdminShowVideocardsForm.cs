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
    public partial class AdminShowVideocardsForm : Form
    {
        private List<string[]> data = new List<string[]>();

        public AdminShowVideocardsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var db = new MyDbContext())
            {
                foreach (var v in db.Videocards)
                {
                    data.Add(new string[] {
                        v.Id.ToString(),
                        v.Name,
                        v.VideoMemory.ToString(),                        
                    });
                }
            }

            foreach (string[] str in data)
                videocardsDataGrid.Rows.Add(str);

            return;
        }

        private void AdminShowVideocardsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            AdminStartForm form = new AdminStartForm();
            form.Show();
            this.Hide();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            data.Clear();
            videocardsDataGrid.Rows.Clear();

            using (var db = new MyDbContext())
            {
                foreach (var v in db.Videocards)
                {
                    data.Add(new string[] {
                        v.Id.ToString(),
                        v.Name,
                        v.VideoMemory.ToString(),
                    });
                }
            }

            foreach (string[] str in data)
                videocardsDataGrid.Rows.Add(str);

            return;
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(videocardsDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminMoreVideoInfoForm form = new AdminMoreVideoInfoForm(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }
        }

        private void addVideocardButton_Click(object sender, EventArgs e)
        {
            AdminAddVideocardForm form = new AdminAddVideocardForm();
            form.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(videocardsDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminAcceptDeletingVideo form = new AdminAcceptDeletingVideo(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }
        }
    }
}
