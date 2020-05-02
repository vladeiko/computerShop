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
    public partial class AdminShowUsersForm : Form
    {
        private List<string[]> data = new List<string[]>();

        public AdminShowUsersForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            using(var db = new MyDbContext())
            {
                foreach(var u in db.Users)
                {
                    data.Add(new string[] { 
                        u.Id.ToString(),
                        u.Login,
                        u.FirstName, 
                        u.SecondName, 
                        u.Email, 
                        u.Phone,
                        u.Status
                    });
                }
            }
            
            foreach(string[] str in data)            
                usersDataGrid.Rows.Add(str);

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
        }
    }
}
