using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

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


        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + ";";

            stOutput += sHeaders + "\r\n";

            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";

                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + ";";

                stOutput += stLine + "\r\n";
            }

            Encoding utf16 = Encoding.GetEncoding(1254);

            byte[] output = utf16.GetBytes(stOutput);

            FileStream fs = new FileStream(filename, FileMode.Create);

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }


        private void importToCsvButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = " Csv file (*.csv)|*.csv";
            sfd.FileName = "export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(computersDataGrid, sfd.FileName);
            }
        }


        // Print table
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            computersDataGrid.Height = computersDataGrid.RowCount * computersDataGrid.RowTemplate.Height * 2;

            Bitmap bm = new Bitmap(computersDataGrid.Width, computersDataGrid.Height);

            computersDataGrid.DrawToBitmap(bm, new Rectangle(0, 0, computersDataGrid.Width, computersDataGrid.Height));

            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();

            PrintDocument doc = new PrintDocument();

            doc.PrintPage += Doc_PrintPage;

            pd.Document = doc;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
    }
}
