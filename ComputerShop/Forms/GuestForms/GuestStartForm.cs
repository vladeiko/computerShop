using System;
using System.Windows.Forms;
using System.Data.Entity;

namespace ComputerShop
{
    public partial class GuestStartForm : Form
    {
        public GuestStartForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                computersDataGrid.DataSource = db.Computers.Local.ToBindingList();
            }

            return;
        }

        private void GuestStartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            form.Show();
            Hide();
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(computersDataGrid.CurrentRow.Cells[0].Value.ToString());
                GuestMoreInfoForm form = new GuestMoreInfoForm(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                computersDataGrid.SelectAll();
                computersDataGrid.ClearSelection();

                computersDataGrid.DataSource = db.Computers.Local.ToBindingList();
            }
        }
    }
}
