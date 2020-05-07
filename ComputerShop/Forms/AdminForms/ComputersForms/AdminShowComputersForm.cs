using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace ComputerShop
{
    public partial class AdminShowComputersForm : Form
    {
        public AdminShowComputersForm()
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

        private void AdminShowComputersForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(computersDataGrid.CurrentRow.Cells[0].Value.ToString());
                acceptDeleteComp form = new acceptDeleteComp(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AdminAddComputerForm form = new AdminAddComputerForm();
            form.ShowDialog();
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(computersDataGrid.CurrentRow.Cells[0].Value.ToString());
                AdminMoreComputerInfoForm form = new AdminMoreComputerInfoForm(id);
                form.ShowDialog();
            }
            catch
            {
                // TODO:
                // Add error (select string)
                return;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            computersDataGrid.SelectAll();
            computersDataGrid.ClearSelection();

            string selectedProc = processorComboBox.Text;
            string selectedVideo = videocardComboBox.Text;
            string selectedRAM = ramComboBox.Text;

            using(var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                List <Computer> filtered = db.Computers.Local.ToList();

                if(procCheckBox.Checked == true)
                    filtered = db.Computers.Where(p => p.Processor.Name == selectedProc).ToList();

                if(videoCheckBox.Checked == true)
                    filtered = filtered.Where(v => v.Videocard.Name == selectedVideo).ToList();

                if(ramCheckBox.Checked == true)
                    filtered = filtered.Where(r => r.RAM.Name == selectedRAM).ToList();

                computersDataGrid.DataSource = filtered;
            }
        }
    }
}
