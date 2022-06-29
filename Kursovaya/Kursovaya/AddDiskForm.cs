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
    public partial class AddDiskForm : Form
    {
        public AddDiskForm()
        {
            InitializeComponent();
        }

        private void AddDiskButton_Click(object sender, EventArgs e)
        {
            if (!HasEmptyFields())
            {
                Catalog catalog = DataBase.LoadBinaryFile();
                Disk disk = new Disk(NameBox.Text, SingerBox.Text, GenreUpDown.Text);
                catalog.disks.Add(disk);
                DataBase.SaveBinaryFile(catalog);

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private bool HasEmptyFields()
        {
            if (NameBox.Text == string.Empty || SingerBox.Text == string.Empty || GenreUpDown.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!");
                return true;
            }

            return false;
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
