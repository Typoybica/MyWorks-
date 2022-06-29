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
    public partial class AddSongForm : Form
    {
        public AddSongForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DiskViewForm diskViewForm = new DiskViewForm();
            diskViewForm.Show();
            Close();
        }

        private void AddDiskButton_Click(object sender, EventArgs e)
        {
            Catalog catalog = DataBase.LoadBinaryFile();
            int dur = ((int)MinuteUpDown.Value * 60) + (int)SecondUpDown.Value;
            Song song = new Song(NameBox.Text, dur);

            for (int i = 0; i < catalog.disks.Count; i++)
            {
                if (catalog.disks[i].Name == DataBuffer.DiskName)
                {
                    if (catalog.disks[i].Singer == DataBuffer.SingerName)
                    {
                        catalog.disks[i].songs.Add(song);
                    }
                }
            }

            DataBase.SaveBinaryFile(catalog);

            DiskViewForm diskViewForm = new DiskViewForm();
            diskViewForm.Show();
            Close();
        }
    }
}
