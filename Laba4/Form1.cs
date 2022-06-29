using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Laba4
{
    public partial class Form1 : Form
    {
       
        public static List<Task> list = new List<Task>();
        public static List<Task> list2 = new List<Task>();
        Random random = new Random();
        public static bool btn1 = false;
        public static bool btn2 = false;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            btn1 = true;
            int Time = int.Parse(textBox5.Text);
            int exit = 0;
            int tmp = 0;
            while (exit != list.Count)
            {
                Application.DoEvents();
                Refresh();
                tmp = Min();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].time == tmp)
                    {
                        list[i].status = "Выполнение";
                        list[i].time -= Time;
                        if (list[i].time <= 0)
                        {
                            list[i].status = "Готово";
                        }
                        break;
                    }
                }

                listView1.Items.Clear();
                for (int j = 0; j < list.Count; j++)
                {
                    ListViewItem item = new ListViewItem(list[j].tasks.ToString());
                    item.SubItems.Add(list[j].time.ToString());
                    item.SubItems.Add(list[j].status);
                    listView1.Items.Add(item);
                }
                exit = Stat();
            }
        }

        public static int Stat()
        {
            int t = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status == "Готово")
                {
                    t++;
                }

            }
            return t;
        }

        public static int Stat2()
        {
            int t = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].status == "Готово")
                {
                    t++;
                }

            }
            return t;
        }
        public static int Min()
        {
            int t = 1000;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].time < t && list[i].time > 0)
                {
                    t = list[i].time;
                }
            }
            return t;
        }
        public static double Min2()
        {
            double  t = 1000;
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].tasks <= t && list2[i].time > 0)
                {
                    t = list2[i].tasks;
                }
            }
            return t;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btn1 = false;
            while (btn1!=true)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
        }
        //if added waiting 
        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(new Task(list.Count, int.Parse(textBox3.Text), "Ожидание"));
            ListViewItem item = new ListViewItem(list[list.Count - 1].tasks.ToString());
            item.SubItems.Add(list[list.Count - 1].time.ToString());
            item.SubItems.Add(list[list.Count - 1].status);
            listView1.Items.Add(item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list2.Add(new Task(list2.Count, int.Parse(textBox2.Text), "Ожидание"));
            ListViewItem item2 = new ListViewItem(list2[list2.Count - 1].tasks.ToString());
            item2.SubItems.Add(list2[list2.Count - 1].time.ToString());
            item2.SubItems.Add(list2[list2.Count - 1].status);
            listView2.Items.Add(item2);
        }
        //stop function
        private void button6_Click(object sender, EventArgs e)
        {
            btn2 = false;
            while (btn2 != true)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn2 = true;
            int Time = int.Parse(textBox1.Text);
            int exit = 0;
            double tmp = 0;
            while (exit != list2.Count)
            {
                Application.DoEvents();
                Refresh();
                tmp = Min2();
                for (int i = 0; i < list2.Count; i++)
                {
                    if (list2[i].tasks == tmp)
                    {
                        list2[i].status = "Выполнение";
                        list2[i].time -= Time;
                        if (list2[i].time <= 0)
                        {
                            list2[i].status = "Готово";
                        }
                    }
                }

                listView2.Items.Clear();
                //list view refresh
                for (int j = 0; j < list2.Count; j++)
                {
                    ListViewItem item2 = new ListViewItem(list2[j].tasks.ToString());
                    item2.SubItems.Add(list2[j].time.ToString());
                    item2.SubItems.Add(list2[j].status);
                    listView2.Items.Add(item2);
                }
                exit = Stat2();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Task
    {
        public int tasks;
        public int time;
        public string status;
        public Task(int tasks, int time, string status)
        {
            this.tasks = tasks;
            this.time = time;
            this.status = status;
        }
       
    }


}
