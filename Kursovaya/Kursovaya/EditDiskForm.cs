using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class EditDiskForm : Form
    {
        public EditDiskForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void EditDiskButton_Click(object sender, EventArgs e)
        {
            Catalog catalog = DataBase.LoadBinaryFile();
            for (int i = 0; i < catalog.disks.Count; i++)
            {
                if (catalog.disks[i].Name == DataBuffer.DiskName)
                {
                    if (catalog.disks[i].Singer == DataBuffer.SingerName)
                    {
                        catalog.disks[i].Name = NameBox.Text;
                        catalog.disks[i].Singer = SingerBox.Text;
                        catalog.disks[i].Genre = GenreUpDown.Text;
                    }
                }
            }
            DataBase.SaveBinaryFile(catalog);
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void EditDiskForm_Load(object sender, EventArgs e)
        {
            NameBox.Text = DataBuffer.DiskName;
            SingerBox.Text = DataBuffer.SingerName;
            GenreUpDown.Text = DataBuffer.GenreName;
        }
    }
}
