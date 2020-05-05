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
    public partial class AdminShowCPUsForm : Form
    {
        private List<string[]> data = new List<string[]>();

        public AdminShowCPUsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var db = new MyDbContext())
            {
                foreach (var p in db.Processors)
                {
                    data.Add(new string[] {
                        p.Id.ToString(),
                        p.Name,
                        p.NumOfCores.ToString(),
                        p.ClockFrequency.ToString(),
                    });
                }
            }

            foreach (string[] str in data)
                processorsDataGrid.Rows.Add(str);

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
            data.Clear();
            processorsDataGrid.Rows.Clear();

            using (var db = new MyDbContext())
            {
                foreach (var p in db.Processors)
                {
                    data.Add(new string[] {
                        p.Id.ToString(),
                        p.Name,
                        p.NumOfCores.ToString(),
                        p.ClockFrequency.ToString(),
                    });
                }
            }

            foreach (string[] str in data)
                processorsDataGrid.Rows.Add(str);

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
