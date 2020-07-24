using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab5
{
    public partial class MainForm : Form
    {
        Manager manag = new Manager();
        XmlSerializer formatter = new XmlSerializer(typeof(Manager));

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manag.list.Add(new Discipl());
           
            try
            {
                manag.list[manag.list.Count() - 1].name = textBox1.Text;
                //manag.list[manag.list.Count() - 1].sem = Convert.ToInt32(textBox2.Text);
                if (checkBox1.Checked)
                    manag.list[manag.list.Count() - 1].sem = 1;
                if (checkBox2.Checked)
                    manag.list[manag.list.Count() - 1].sem1 = 2;
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    manag.list[manag.list.Count() - 1].sem = 1;
                    manag.list[manag.list.Count() - 1].sem1 = 2;
                }
                manag.list[manag.list.Count() - 1].kurs = Convert.ToInt32(comboBox1.Text);
                manag.list[manag.list.Count() - 1].spec = comboBox2.Text;
                manag.list[manag.list.Count() - 1].numoflec = Convert.ToInt32(trackBar1.Value);
                manag.list[manag.list.Count() - 1].numoflab = Convert.ToInt32(textBox4.Text);
                manag.list[manag.list.Count() - 1].typeofcontrol = comboBox3.Text;
                if (radioButton1.Checked)
                    manag.list[manag.list.Count() - 1].Lector.POL = "Мужской";
                if(radioButton2.Checked)
                    manag.list[manag.list.Count() - 1].Lector.POL = "Женский";
                manag.list[manag.list.Count() - 1].Lector.Cafedra = comboBox4.Text;
                manag.list[manag.list.Count() - 1].Lector.FIO = textBox5.Text;
                manag.list[manag.list.Count() - 1].Lector.Date = dateTimePicker1.Text;
                MessageBox.Show("Информация успешно обновлена!");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label14.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }


        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            try
            {
                for(int i = 0; i < manag.list.Count; i++)
                {

                    textBox3.Text += "Информация о дисциплине номер " +Convert.ToString(i+1)+ Environment.NewLine;
                    textBox3.Text += "Название - " +  Convert.ToString(manag.list[i].name)+Environment.NewLine;
                    textBox3.Text += "Семестр - " + Convert.ToString(manag.list[i].sem) + Environment.NewLine;
                    textBox3.Text += "Семестр - " + Convert.ToString(manag.list[i].sem1) + Environment.NewLine;
                    textBox3.Text += "Курс - " + Convert.ToString(manag.list[i].kurs) + Environment.NewLine;
                    textBox3.Text += "Специальность - " + Convert.ToString(manag.list[i].spec) + Environment.NewLine;
                    textBox3.Text += "Кол-во часов лекций - " + Convert.ToString(manag.list[i].numoflec) + Environment.NewLine;
                    textBox3.Text += "Кол-во часов лабораторных - " + Convert.ToString(manag.list[i].numoflab) + Environment.NewLine;
                    textBox3.Text += "Тип контроля - " + Convert.ToString(manag.list[i].typeofcontrol) + Environment.NewLine;
                    textBox3.Text += "Информация о преподавателе" + Environment.NewLine + "Пол - "+ Convert.ToString(manag.list[i].Lector.POL) + Environment.NewLine;
                    textBox3.Text += "Кафедра - " + Convert.ToString(manag.list[i].Lector.Cafedra) + Environment.NewLine;
                    textBox3.Text += "Фамилия - " + Convert.ToString(manag.list[i].Lector.FIO) + Environment.NewLine;
                    textBox3.Text += "Дата рождения - " + Convert.ToString(manag.list[i].Lector.Date) + Environment.NewLine;
                    textBox3.Text += "----------------------------------------------" + Environment.NewLine;

                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {                
                using (FileStream fs = new FileStream("info.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, manag);

                    MessageBox.Show("Объект успешно сериализован");
                }
            }
            catch(Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("info.xml", FileMode.OpenOrCreate))
                {
                    Manager newManag = (Manager)formatter.Deserialize(fs);
                    textBox3.Text = "Десериализованая информация" + Environment.NewLine + "(o_o)"+Environment.NewLine;
                    try
                    {
                        for (int i = 0; i < manag.list.Count; i++)
                        {

                            textBox3.Text += "Информация о дисциплине номер " + Convert.ToString(i + 1) + Environment.NewLine;
                            textBox3.Text += "Название - " + Convert.ToString(newManag.list[i].name) + Environment.NewLine;
                            textBox3.Text += "Семестр - " + Convert.ToString(newManag.list[i].sem) + Environment.NewLine;
                            textBox3.Text += "Семестр - " + Convert.ToString(newManag.list[i].sem1) + Environment.NewLine;
                            textBox3.Text += "Курс - " + Convert.ToString(newManag.list[i].kurs) + Environment.NewLine;
                            textBox3.Text += "Специальность - " + Convert.ToString(newManag.list[i].spec) + Environment.NewLine;
                            textBox3.Text += "Кол-во часов лекций - " + Convert.ToString(newManag.list[i].numoflec) + Environment.NewLine;
                            textBox3.Text += "Кол-во часов лабораторных - " + Convert.ToString(newManag.list[i].numoflab) + Environment.NewLine;
                            textBox3.Text += "Тип контроля - " + Convert.ToString(newManag.list[i].typeofcontrol) + Environment.NewLine;
                            textBox3.Text += "Информация о преподавателе" + Environment.NewLine + "Пол - " + Convert.ToString(newManag.list[i].Lector.POL) + Environment.NewLine;
                            textBox3.Text += "Кафедра - " + Convert.ToString(newManag.list[i].Lector.Cafedra) + Environment.NewLine;
                            textBox3.Text += "Фамилия - " + Convert.ToString(newManag.list[i].Lector.FIO) + Environment.NewLine;
                            textBox3.Text += "Дата рождения - " + Convert.ToString(newManag.list[i].Lector.Date) + Environment.NewLine;
                            textBox3.Text += "----------------------------------------------" + Environment.NewLine;

                        }
                    }
                    catch (Exception s)
                    {
                        MessageBox.Show(s.Message);
                    }

                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(@"D:\лабы\2 sem\oop\lab5\lab5\bin\Debug\info.xml");
            manag.list.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
