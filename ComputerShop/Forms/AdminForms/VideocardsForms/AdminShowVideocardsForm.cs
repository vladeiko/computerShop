using System;
using System.Windows.Forms;
using System.Data.Entity;

namespace ComputerShop
{
    public partial class AdminShowVideocardsForm : Form
    {
        public AdminShowVideocardsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using(var db = new MyDbContext())
            {
                db.Videocards.Load();

                videocardsDataGrid.DataSource = db.Videocards.Local.ToBindingList();
            }
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
            using(var db = new MyDbContext())
            {
                db.Videocards.Load();

                videocardsDataGrid.SelectAll();
                videocardsDataGrid.ClearSelection();
                videocardsDataGrid.DataSource = db.Videocards.Local.ToBindingList();
            }
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
