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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        MyTask task = new MyTask();
        DateTime? startTime = DateTime.Now;
        DateTime? endTime = DateTime.Now;
        public AddWindow()
        {
            InitializeComponent();
            StartCalendar.DisplayDateStart = DateTime.Now;            
            EndCalendar.DisplayDateStart = DateTime.Now;
            StartCalendar.SelectedDate = DateTime.Now;
            EndCalendar.SelectedDate = DateTime.Now;
            NameTextBox.Text = "Задача  " + (Manager.tasks.Count+1);
            AboutTextBox.Text = "Описание задачи " + (Manager.tasks.Count + 1);
            task.status = Status.Undone;
            task.name = NameTextBox.Text;
            task.startTime = startTime;
            task.endTime = endTime;
            task.description = AboutTextBox.Text;
            this.DataContext = task;
            RadioButton radioButton = new RadioButton();
            
        }
        public AddWindow(object mytask)
        {
            task = (MyTask)mytask;
            InitializeComponent();
            StartCalendar.DisplayDateStart = task.startTime;
            EndCalendar.DisplayDateStart = task.startTime;
            StartCalendar.SelectedDate = task.startTime;
            EndCalendar.SelectedDate = task.endTime;
            NameTextBox.Text = task.name;
            AboutTextBox.Text = task.description;
            this.DataContext = task;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (task.startTime <= task.endTime)
            {
                Manager.Add(task);
                this.Close();                
            }
        }

        private void Period_choice(object sender, RoutedEventArgs e)
        {
            RadioButton selected = (RadioButton)e.Source;
            switch(selected.Name)
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
            switch(selected.Name)
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
            switch(selected.Name)
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

        private void StartDate_choice(object sender ,SelectionChangedEventArgs e)
        {            
            DateTime? selected = StartCalendar.SelectedDate;            
            task.startTime = selected;
        }
        private void EndDate_choice(object sender, RoutedEventArgs e)
        {            
            DateTime? selected = EndCalendar.SelectedDate;
            task.endTime = selected;   
        }
    }


}
