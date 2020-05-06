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
    public partial class AdminShowComputersForm : Form
    {
        private List<string[]> data = new List<string[]>();

        public AdminShowComputersForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var db = new MyDbContext())
            {
                foreach (var c in db.Computers)
                {
                    //Processor proc = db.Processors.SingleOrDefault(p => p.Id == c.ProcessorId);
                    //Videocard video = db.Videocards.SingleOrDefault(v => v.Id == c.VideocardId);
                    //RAM memory = db.RAMs.SingleOrDefault(m => m.Id == c.RAMId);

                    data.Add(new string[] {
                        c.Id.ToString(),
                        c.Manufacturer,
                        c.Model,
                        c.Processor.Name,
                        c.Videocard.Name,
                        c.RAM.Name,
                        c.Price.ToString()
                    });
                }
            }

            foreach(string[] str in data)
                computersDataGrid.Rows.Add(str);

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
    }
}
