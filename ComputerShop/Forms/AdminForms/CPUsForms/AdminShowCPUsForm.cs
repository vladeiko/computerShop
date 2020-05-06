using System;
using System.Windows.Forms;
using System.Data.Entity;

namespace ComputerShop
{
    public partial class AdminShowCPUsForm : Form
    {
        public AdminShowCPUsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var db = new MyDbContext())
            {
                db.Processors.Load();

                processorsDataGrid.DataSource = db.Processors.Local.ToBindingList();
            }

            return;
        }

        private void AdminShowCPUsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void goBackButton_Click(object sender, EventArgs e)
        {
            AdminStartForm form = new AdminStartForm();
            form.Show();
            Hide();
        }

        private void addProcessorButton_Click(object sender, EventArgs e)
        {
            AdminAddCPUForm form = new AdminAddCPUForm();
            form.ShowDialog();
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(processorsDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminMoreCPUInfoForm form = new AdminMoreCPUInfoForm(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }

            return;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                db.Processors.Load();

                processorsDataGrid.SelectAll();
                processorsDataGrid.ClearSelection();
                processorsDataGrid.DataSource = db.Processors.Local.ToBindingList();
            }

            return;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(processorsDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminAcceptDeletingProc form = new AdminAcceptDeletingProc(id);
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
