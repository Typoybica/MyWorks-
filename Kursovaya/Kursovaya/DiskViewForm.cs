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
    public partial class DiskViewForm : Form
    {
        public DiskViewForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void RefreshSongGrid()
        {
            int index = 0;
            Catalog catalog = DataBase.LoadBinaryFile();

            SongGridView.Rows.Clear();

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

            if (catalog.disks[index].songs.Count != 0)
            {
                for (int i = 0; i < catalog.disks[index].songs.Count; i++)
                {
                    string minutes = (catalog.disks[index].songs[i].Duration / 60).ToString();
                    string seconds;
                    if ((catalog.disks[index].songs[i].Duration % 60) < 10)
                    {
                        seconds = "0" + (catalog.disks[index].songs[i].Duration % 60).ToString();
                    }
                    else
                    {
                        seconds = (catalog.disks[index].songs[i].Duration % 60).ToString();
                    }
                    string durationOutput = string.Format($"{minutes}:{seconds}");
                    SongGridView.Rows.Add(catalog.disks[index].songs[i].Name, durationOutput);
                }
            }
        }

        private void DiskViewForm_Load(object sender, EventArgs e)
        {
            RefreshSongGrid();
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            AddSongForm addSongForm = new AddSongForm();
            addSongForm.Show();
            Close();
        }

        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            Catalog catalog = DataBase.LoadBinaryFile();

            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удаление композиции", MessageBoxButtons.OKCancel);


            if (dialogResult == DialogResult.OK)
            {
                int index = 0;
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
                    if (catalog.disks[index].songs[i].Name == catalog.disks[index].songs[SongGridView.CurrentRow.Index].Name)
                    {
                        if (catalog.disks[index].songs[i].Duration == catalog.disks[index].songs[SongGridView.CurrentRow.Index].Duration)
                        {
                            catalog.disks[index].songs.RemoveAt(i);
                            SongGridView.Rows.RemoveAt(SongGridView.CurrentRow.Index);
                            break;
                        }
                    }
                }

                DataBase.SaveBinaryFile(catalog);
                RefreshSongGrid();
            }
        }

        private void EditSongButton_Click(object sender, EventArgs e)
        {
            Catalog catalog = DataBase.LoadBinaryFile();
            int index = 0;
            int index2 = 0;
            for (int i = 0; i < SongGridView.Rows.Count; i++)
            {
                if (SongGridView.Rows[i].Selected == true)
                {
                    DataBuffer.SongName = (string)SongGridView.Rows[i].Cells[0].Value;
                    for (int o = 0; o < catalog.disks.Count; o++)
                    {
                        if (catalog.disks[o].Name == DataBuffer.DiskName)
                        {
                            if (catalog.disks[o].Singer == DataBuffer.SingerName)
                            {
                                index = o;
                            }
                        }
                    }
                    for (int a = 0; a < catalog.disks[index].songs.Count; a++)
                    {
                        if (catalog.disks[index].songs[a].Name == DataBuffer.SongName)
                        {
                            index2 = a;
                        }
                    }
                    DataBuffer.SongDuration = catalog.disks[index].songs[index2].Duration;
                }
            }
            EditSongForm editSongForm = new EditSongForm();
            editSongForm.Show();
            Close();
        }
    }
}
