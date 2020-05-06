using System;
using System.Windows.Forms;
using System.Data.Entity;

namespace ComputerShop
{
    public partial class AdminShowRAMsForm : Form
    {
        public AdminShowRAMsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var db = new MyDbContext())
            {
                db.RAMs.Load();

                ramDataGrid.DataSource = db.RAMs.Local.ToBindingList();
            }

            return;
        }

        private void AdminShowRAMsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            AdminStartForm form = new AdminStartForm();
            form.Show();
            Hide();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                db.RAMs.Load();

                ramDataGrid.SelectAll();
                ramDataGrid.ClearSelection();
                ramDataGrid.DataSource = db.RAMs.Local.ToBindingList();
            }

            return;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(ramDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminAcceptDeletingRam form = new AdminAcceptDeletingRam(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }
        }

        private void addRamButton_Click(object sender, EventArgs e)
        {
            AdminAddRamForm form = new AdminAddRamForm();
            form.ShowDialog();
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(ramDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminMoreRAMInfoForm form = new AdminMoreRAMInfoForm(id);
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
