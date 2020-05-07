using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShop
{
    public partial class UserStartForm : Form
    {
        public UserStartForm()
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

                processorComboBox.DataSource = db.Processors.ToList();

                videocardComboBox.DataSource = db.Videocards.ToList();

                ramComboBox.DataSource = db.RAMs.ToList();
            }

            return;
        }

        private void UserStartForm_FormClosed(object sender, FormClosedEventArgs e)
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
                UserMoreCompInfoForm form = new UserMoreCompInfoForm(id);
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
            using(var db = new MyDbContext())
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

        private void accountButton_Click(object sender, EventArgs e)
        {
            UserShowAccountForm form = new UserShowAccountForm();
            form.ShowDialog();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            computersDataGrid.SelectAll();
            computersDataGrid.ClearSelection();

            string selectedProc = processorComboBox.Text;
            string selectedVideo = videocardComboBox.Text;
            string selectedRAM = ramComboBox.Text;

            using (var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                List<Computer> filtered = db.Computers.Local.ToList();

                if (procCheckBox.Checked == true)
                    filtered = db.Computers.Where(p => p.Processor.Name == selectedProc).ToList();

                if (videoCheckBox.Checked == true)
                    filtered = filtered.Where(v => v.Videocard.Name == selectedVideo).ToList();

                if (ramCheckBox.Checked == true)
                    filtered = filtered.Where(r => r.RAM.Name == selectedRAM).ToList();

                computersDataGrid.DataSource = filtered;
            }
        }
    }
}
