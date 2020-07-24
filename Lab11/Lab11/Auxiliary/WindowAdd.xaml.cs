using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using DAL.Models;
using DAL.Operations;
using Helpers.Validator;
using Img = System.Drawing.Image;

namespace Lab11.Auxiliary
{
    public class AddedEventArgs
    {
        public AddedEventArgs(Teacher t)
        {
            Model = t;
        }
        public Teacher Model { get; set; }
    }
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public string TeacherName { get; set; }
        public int WorkExperience { get; set; }
        public int TeacherAge { get; set; }
        public Byte[] Photo { get; set; }

        public WindowAdd()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event EventHandler<AddedEventArgs> Added;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Teacher t = new Teacher() { TeacherName = TeacherName, TeacherAge = TeacherAge, WorkExperience = WorkExperience, TeacherPhoto = Photo };
            // Validation
            var validator = new Validator();
            if (validator.IsValid(t))
            {
                IRepository<Teacher> crud = new TeacherRepository();
                crud.Create(t);

                EventHandler<AddedEventArgs> handler = Added;
                handler?.Invoke(this, new AddedEventArgs(t));
                this.Close();
            }


            foreach (var error in validator.Results)
            {
                MessageBox.Show($"{error.ErrorMessage}");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            dlg.FileName = @"Picture";
            dlg.DefaultExt = "*.png";
            dlg.Filter = "Pictures (.png)|*.png";

            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;

                Img pic = Img.FromFile(filename);
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                pic.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] b = memoryStream.ToArray();
                if (b.Length > 8000)
                {
                    MessageBox.Show("Image is too big");
                    this.Close();
                }
                else
                {
                    Photo = b;
                }
                
            }
        }
    }
}
