using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class UserMoreCompInfoForm : Form
    {
        public int compId;

        public UserMoreCompInfoForm(int id)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            compId = id;

            using (var db = new MyDbContext())
            {
                db.Computers.Load();
                db.Processors.Load();
                db.Videocards.Load();
                db.RAMs.Load();

                Computer toShow = db.Computers.SingleOrDefault(c => c.Id == compId);

                if (toShow == null)
                {
                    // TODO:
                    // Add not found error
                    return;
                }

                manufacturerTextBox.Text = toShow.Manufacturer;
                modelTextBox.Text = toShow.Model;
                priceTextBox.Text = toShow.Price.ToString();
                imagePictureBox.ImageLocation = toShow.ImagePath;

                processorTextBox.Text = toShow.Processor.Name;
                numOfCoresTextBox.Text = toShow.Processor.NumOfCores.ToString();
                mhzTextBox.Text = toShow.Processor.ClockFrequency.ToString();

                videocardTextBox.Text = toShow.Videocard.Name;
                videomemoryTextBox.Text = toShow.Videocard.VideoMemory.ToString();

                ramTextBox.Text = toShow.RAM.Name;
                ramSizeTextBox.Text = toShow.RAM.Size.ToString();
                
            }
        }
    }
}
