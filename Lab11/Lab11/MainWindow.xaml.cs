using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using DAL.Models;
using DAL.Operations;
using Helpers.Validator;
using Lab11.Auxiliary;
using System.Collections.ObjectModel;

namespace Lab11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Teacher> Teachers { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            //DataGridInstance.Add
            if (!GeneralOperations.HasTable("Teachers"))
            {
                GeneralOperations.CreateTeachersTable();
            }
            IRepository<Teacher> tr = new TeacherRepository();
            Teachers = new ObservableCollection<Teacher>(tr.GetAll());
            DataGridInstance.ItemsSource = Teachers;
        }

        public void Add_Click(object sender,EventArgs e)
        {
            WindowAdd wnd = new WindowAdd();
            wnd.Added += TeacherAdded;
            wnd.Show();
        }
        private void TeacherAdded(object sender, AddedEventArgs e)
        {
            Teachers.Add(e.Model);
        }

        private void DataGridInstance_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        { 
            Teacher t = (Teacher)e.Row.Item;
            var validator = new Validator();
            if (validator.IsValid(t))
            {
                IRepository<Teacher> tr = new TeacherRepository();
                tr.Delete(t);// EDIT
                tr.Create(t);
            }
            else
            {
                string errorStr = string.Empty;
                foreach (var error in validator.Results)
                {
                    MessageBox.Show($"{error.ErrorMessage}");
                }
                
                e.Cancel = true;
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridInstance.SelectedItem != null)
            {
                IRepository<Teacher> tr = new TeacherRepository();
                tr.Delete((Teacher)DataGridInstance.SelectedValue);
                Teachers.Remove((Teacher)DataGridInstance.SelectedValue);
            }
            else
            {
                MessageBox.Show("Please choose item");
            }
            
        }
    }
}
