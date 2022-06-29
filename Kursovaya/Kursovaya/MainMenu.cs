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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            DiskGridView.Rows[0].Cells[0].Selected = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDiskForm addDiskForm = new AddDiskForm();
            addDiskForm.Show();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteDiskButton_Click(object sender, EventArgs e)
        {
            Catalog catalog = DataBase.LoadBinaryFile();

            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удаление диска", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                for (int i = 0; i < catalog.disks.Count; i++)
                {
                    if (catalog.disks[i].Name == catalog.disks[DiskGridView.CurrentRow.Index].Name)
                    {
                        if(catalog.disks[i].Singer == catalog.disks[DiskGridView.CurrentRow.Index].Singer)
                        {
                            catalog.disks.RemoveAt(i);
                            DiskGridView.Rows.RemoveAt(DiskGridView.CurrentRow.Index);
                            break;
                        }
                    }
                }

                DataBase.SaveBinaryFile(catalog);
                RefreshDataGrid();
            }
        }

        private void EditDiskButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DiskGridView.Rows.Count; i++)
            {
                if (DiskGridView.Rows[i].Selected == true)
                {
                    DataBuffer.DiskName = (string)DiskGridView.Rows[i].Cells[0].Value;
                    DataBuffer.SingerName = (string)DiskGridView.Rows[i].Cells[1].Value;
                    DataBuffer.GenreName = (string)DiskGridView.Rows[i].Cells[2].Value;
                }
            }
            EditDiskForm editDiskForm = new EditDiskForm();
            editDiskForm.Show();
            Close();
        }

        private void RefreshDataGrid()
        {
            Catalog catalog = DataBase.LoadBinaryFile();

            DiskGridView.Rows.Clear();

            if (catalog.disks.Count != 0)
            {
                for (int i = 0; i < catalog.disks.Count; i++)
                {
                    DiskGridView.Rows.Add(catalog.disks[i].Name, catalog.disks[i].Singer, catalog.disks[i].Genre, catalog.disks[i].songs.Count);
                }
            }
        }

        private void DiskGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Catalog catalog = DataBase.LoadBinaryFile();
            //for (int i = 0; i < catalog.disks.Count; i++)
            //{
            //    if (catalog.disks[i].Name == catalog.disks[DiskGridView.CurrentRow.Index].Name)
            //    {
            //        if (catalog.disks[i].Singer == catalog.disks[DiskGridView.CurrentRow.Index].Singer)
            //        {
            //            DataBuffer.DiskName = catalog.disks[i].Name;
            //            DataBuffer.SingerName = catalog.disks[i].Singer;
            //            DataBuffer.GenreName = catalog.disks[i].Singer;
            //        }
            //    }
            //}
        }

        private void DiskContentButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DiskGridView.Rows.Count; i++)
            {
                if (DiskGridView.Rows[i].Selected == true)
                {
                    DataBuffer.DiskName = (string)DiskGridView.Rows[i].Cells[0].Value;
                    DataBuffer.SingerName = (string)DiskGridView.Rows[i].Cells[1].Value;
                    DataBuffer.GenreName = (string)DiskGridView.Rows[i].Cells[2].Value;
                }
            }
            DiskViewForm diskViewForm = new DiskViewForm();
            diskViewForm.Show();
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(NameRadioButton.Checked==false && SingerRadioButton.Checked == false && GenreRadioButton.Checked == false)
            {
                MessageBox.Show("Выберите критерий поиска");
            }
            else
            {
                if (NameRadioButton.Checked == true)
                {
                    if (NameBox.Text != string.Empty)
                    {
                        Catalog catalog = DataBase.LoadBinaryFile();

                        DiskGridView.Rows.Clear();

                        if (catalog.disks.Count != 0)
                        {
                            for (int i = 0; i < catalog.disks.Count; i++)
                            {
                                if (catalog.disks[i].Name.StartsWith(NameBox.Text))
                                {
                                    DiskGridView.Rows.Add(catalog.disks[i].Name, catalog.disks[i].Singer, catalog.disks[i].Genre, catalog.disks[i].songs.Count);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните нужное поле!", "Ошибка!");
                    }
                }
                else if (SingerRadioButton.Checked == true)
                {
                    if (SingerBox.Text != string.Empty)
                    {
                        Catalog catalog = DataBase.LoadBinaryFile();

                        DiskGridView.Rows.Clear();

                        if (catalog.disks.Count != 0)
                        {
                            for (int i = 0; i < catalog.disks.Count; i++)
                            {
                                if (catalog.disks[i].Singer.StartsWith(SingerBox.Text))
                                {
                                    DiskGridView.Rows.Add(catalog.disks[i].Name, catalog.disks[i].Singer, catalog.disks[i].Genre, catalog.disks[i].songs.Count);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните нужное поле!", "Ошибка!");
                    }
                }
                else if (GenreRadioButton.Checked == true)
                {
                    if (GenreUpDown.Text != string.Empty)
                    {
                        Catalog catalog = DataBase.LoadBinaryFile();

                        DiskGridView.Rows.Clear();

                        if (catalog.disks.Count != 0)
                        {
                            for (int i = 0; i < catalog.disks.Count; i++)
                            {
                                if (catalog.disks[i].Genre == GenreUpDown.Text) 
                                {
                                    DiskGridView.Rows.Add(catalog.disks[i].Name, catalog.disks[i].Singer, catalog.disks[i].Genre, catalog.disks[i].songs.Count);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните нужное поле!", "Ошибка!");
                    }
                }
            }
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            NameRadioButton.Checked = false;
            SingerRadioButton.Checked = false;
            GenreRadioButton.Checked = false;
            NameBox.Text = string.Empty;
            SingerBox.Text = string.Empty;
            GenreUpDown.Text = string.Empty;
            RefreshDataGrid();
        }
    }
}
