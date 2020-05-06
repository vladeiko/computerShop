using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AdminMoreRAMInfoForm : Form
    {
        public int ramId;

        public AdminMoreRAMInfoForm()
        {
            InitializeComponent();
        }

        public AdminMoreRAMInfoForm(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            ramId = id;

            using (var db = new MyDbContext())
            {
                RAM toShow = db.RAMs.SingleOrDefault(r => r.Id == ramId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                ramNameTextBox.Text = toShow.Name;
                sizeTextBox.Text = toShow.Size.ToString();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            acceptButton.Visible = true;
            declineButton.Visible = true;
            editButton.Visible = false;

            ramNameTextBox.ReadOnly = false;
            sizeTextBox.ReadOnly = false;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                string ramName = ramNameTextBox.Text;
                string size = sizeTextBox.Text;

                RAM editing = db.RAMs.SingleOrDefault(r => r.Id == ramId);

                if (ramName == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                if (size == "")
                {
                    // TODO:
                    // Add error (empty)
                }

                editing.Name = ramName;
                editing.Size = Convert.ToInt32(size);

                db.SaveChanges();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;

            ramNameTextBox.ReadOnly = true;
            sizeTextBox.ReadOnly = true;

            return;
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            using (var db = new MyDbContext())
            {
                RAM toShow = db.RAMs.SingleOrDefault(r => r.Id == ramId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                ramNameTextBox.Text = toShow.Name;
                sizeTextBox.Text = toShow.Size.ToString();
            }

            acceptButton.Visible = false;
            declineButton.Visible = false;
            editButton.Visible = true;

            ramNameTextBox.ReadOnly = true;
            sizeTextBox.ReadOnly = true;

            return;
        }
    }
}
