using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4lab2
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var vozr = from u in list
                       orderby u 
                       select u;
            foreach (var b in vozr)
            {
                listBox1.Items.Add("Гусь " + b);
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
            try
            {
                Gus gus = new Gus();
                Random rnd = new Random();
                int size = Convert.ToInt32(txbSize.Text);
                int[] mass = new int[size];
                for (int i = 0; i < size; i++)
                {
                    mass[i] = rnd.Next(0, 20);
                }
                for (int j = 0; j < size; j++)
                {
                    listBox1.Items.Add("Гусь " + mass[j]);
                }
                list.AddRange(mass);
            }
            catch
            {
                txbSize.Text = "Ошибка генерации";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var vozr = from u in list
                       orderby u descending
                       select u;
            foreach (var b in vozr)
            {
                listBox2.Items.Add("Гусь " + b);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var vozr = list.Min();
            listBox1.Items.Add("Гусь " + vozr);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            var vozr = list.Average();
            listBox3.Items.Add("Гусь " + vozr);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var vozr = list.Max();
            listBox2.Items.Add("Гусь " + vozr);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Gus
    {
        public string Gusname { get; set; } = "Гусь ";
        public int Gusnumber { get; set; }
    }
}

