using System;
using System.Windows.Forms;
using System.Data.Entity;

namespace ComputerShop
{
    public partial class AdminShowUsersForm : Form
    {
        public AdminShowUsersForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var db = new MyDbContext())
            {
                db.Users.Load();

                usersDataGrid.DataSource = db.Users.Local.ToBindingList();
            }

            return;
        }

        private void AdminShowUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            AdminStartForm form = new AdminStartForm();
            form.Show();
            Hide();
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(usersDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminMoreUserInfoForm form = new AdminMoreUserInfoForm(id);
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
                db.Users.Load();

                usersDataGrid.SelectAll();
                usersDataGrid.ClearSelection();
                usersDataGrid.DataSource = db.Users.Local.ToBindingList();
            }
            return;
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            AdminAddUserForm form = new AdminAddUserForm();
            form.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(usersDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminAcceptDeletingUser form = new AdminAcceptDeletingUser(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }

            //return;
        }
    }
}
