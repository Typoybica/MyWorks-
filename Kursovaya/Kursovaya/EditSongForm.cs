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
    public partial class EditSongForm : Form
    {
        public EditSongForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditSongForm_Load(object sender, EventArgs e)
        {
            NameBox.Text = DataBuffer.SongName;
            MinuteUpDown.Value = DataBuffer.SongDuration / 60;
            SecondUpDown.Value = DataBuffer.SongDuration % 60;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DiskViewForm diskViewForm = new DiskViewForm();
            diskViewForm.Show();
            Close();
        }

        private void AddDiskButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            int index2 = 0;
            Catalog catalog = DataBase.LoadBinaryFile();
            for (int i = 0; i < catalog.disks.Count; i++)
            {
                if (catalog.disks[i].Name == DataBuffer.DiskName)
                {
                    if (catalog.disks[i].Singer == DataBuffer.SingerName)
                    {
                        index = i;
                    }
                }
            }
            for (int i = 0; i < catalog.disks[index].songs.Count; i++)
            {
                if (catalog.disks[index].songs[i].Name == DataBuffer.SongName) 
                {
                    index2 = i;
                }
            }
            catalog.disks[index].songs[index2].Name = NameBox.Text;
            catalog.disks[index].songs[index2].Duration = (int)MinuteUpDown.Value * 60 + (int)SecondUpDown.Value;
            DataBase.SaveBinaryFile(catalog);
            DiskViewForm diskViewForm = new DiskViewForm();
            diskViewForm.Show();
            Close();
        }
    }
}
