using _7_8.entity;
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
using System.Windows.Shapes;

namespace _7_8
{
    /// <summary>
    /// Логика взаимодействия для AdditionalFunc.xaml
    /// </summary>
    public partial class AdditionalFunc : Window
    {
        MyTask task = new MyTask();
        public AdditionalFunc()
        {
            InitializeComponent();
            FindTB.Text = "Поиск по имени";
        }
        private void Period_choice(object sender, RoutedEventArgs e)
        {
            RadioButton selected = (RadioButton)e.Source;
            switch (selected.Name)
            {
                case "Single":
                    task.period = Period.Single;
                    break;
                case "EveryWeek":
                    task.period = Period.Every_week;
                    break;
                case "EveryMonth":
                    task.period = Period.Every_month;
                    break;
                case "EveryYear":
                    task.period = Period.Every_year;
                    break;
            }
        }
        private void Priority_choice(object sender, RoutedEventArgs e)
        {
            RadioButton selected = (RadioButton)e.Source;
            switch (selected.Name)
            {
                case "Low":
                    task.priority = Priority.Low; break;
                case "Middle":
                    task.priority = Priority.Middle; break;
                case "High":
                    task.priority = Priority.High; break;
            }
        }

        private void Category_choice(object sender, RoutedEventArgs e)
        {
            RadioButton selected = (RadioButton)e.Source;
            switch (selected.Name)
            {
                case "Home":
                    task.category = Category.Home; break;
                case "Family":
                    task.category = Category.Family; break;
                case "Cources":
                    task.category = Category.Courses; break;
                case "Work":
                    task.category = Category.Work; break;
                case "Rest":
                    task.category = Category.Rest; break;
                case "Study":
                    task.category = Category.Study; break;
            }
        }
        void searchByPeriod()
        {
            Manager.taskFind.Clear();
            foreach(var taskF in Manager.tasks)
            {
                if (taskF.period == task.period)
                    Manager.taskFind.Add(taskF);
            }
        }
        void searchByPriority()
        {
            Manager.taskFind.Clear();
            foreach (var taskF in Manager.tasks)
            {
                if (taskF.priority == task.priority)
                    Manager.taskFind.Add(taskF);
            }
        }
        void searchByCategory()
        {
            Manager.taskFind.Clear();
            foreach (var taskF in Manager.tasks)
            {
                if (taskF.category == task.category)
                    Manager.taskFind.Add(taskF);
            }
        }
        void searchByStatus()
        {
            Manager.taskFind.Clear();
            foreach (var taskF in Manager.tasks)
            {
                if (taskF.status == task.status)
                    Manager.taskFind.Add(taskF);
            }
        }
        void searchByName()
        {
            task.name = FindTB.Text;
            Manager.taskFind.Clear();
            foreach (var taskF in Manager.tasks)
            {
                if (taskF.name == task.name)
                    Manager.taskFind.Add(taskF);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            searchByPeriod();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            searchByPriority();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            searchByCategory();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            searchByName();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            searchByStatus();
            this.Close();
        }

        private void Status_choice(object sender, RoutedEventArgs e)
        {
            RadioButton selected = (RadioButton)e.Source;
            switch (selected.Name)
            {
                case "Done":
                    task.status = Status.Done; break;
                case "Undone":
                    task.status = Status.Undone; break;                
            }
        }
    }
}
