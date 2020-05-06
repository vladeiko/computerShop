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
    public partial class AdminShowRAMsForm : Form
    {
        private List<string[]> data = new List<string[]>();

        public AdminShowRAMsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using(var db = new MyDbContext())
            {
                foreach (var r in db.RAMs)
                {
                    data.Add(new string[] {
                        r.Id.ToString(),
                        r.Name,
                        r.Size.ToString(),
                    });
                }
            }

            foreach (string[] str in data)
                ramDataGrid.Rows.Add(str);

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
            data.Clear();
            ramDataGrid.Rows.Clear();

            using (var db = new MyDbContext())
            {
                foreach (var r in db.RAMs)
                {
                    data.Add(new string[] {
                        r.Id.ToString(),
                        r.Name,
                        r.Size.ToString(),
                    });
                }
            }

            foreach (string[] str in data)
                ramDataGrid.Rows.Add(str);

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
