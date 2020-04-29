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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(this);
            form.Show();
            Hide();
        }
    }
}
