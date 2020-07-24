using _7_8.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace _7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            string path = @"logo.jpg";
            InitializeComponent();
            DayDataGrid.ItemsSource = Manager.tasks;
            Calendar.DisplayDateStart = DateTime.Now;

            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            List<string> styles = new List<string> { "light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "light";

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
        }
        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri("Resources/"+style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }
            
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if ((MyTask)DayDataGrid.SelectedItem != null)
            {
                Manager.Remove((MyTask)DayDataGrid.SelectedItem);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if ((MyTask)DayDataGrid.SelectedItem != null)
            {
                AddWindow addWindow = new AddWindow((MyTask)DayDataGrid.SelectedItem);
                Manager.tasks.Remove((MyTask)DayDataGrid.SelectedItem);
                addWindow.Show();
            }
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            selectDate();
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            DayDataGrid.ItemsSource = Manager.tasks;
        }


        void selectDate()
        {
            Manager.tasktoday.Clear();
            foreach (var task in Manager.tasks)
            {
                if (Calendar.SelectedDate <= task.endTime && Calendar.SelectedDate >= task.startTime)
                {
                    Manager.tasktoday.Add(task);
                }
            }
            DayDataGrid.ItemsSource = Manager.tasktoday;
        }

        private void SaveAll_Click(object sender, RoutedEventArgs e)
        {
            Manager.Serialize();
        }

        private void LoadAll_Click(object sender, RoutedEventArgs e)
        {
            Manager.DeSerialize();
        }

        private void AdditionalFunc_Click(object sender, RoutedEventArgs e)
        {
            ControlWindow controlWindow = new ControlWindow();
            controlWindow.ShowDialog();
            AdditionalFunc additionalWnd = new AdditionalFunc();
            additionalWnd.Show();
            DayDataGrid.ItemsSource = Manager.taskFind;            
            AddButton.FontSize = controlWindow.MyCustom.Slaidorcik.Value;
            
        }

        private void Doneundone_Click(object sender, RoutedEventArgs e)
        {
            if ((MyTask)DayDataGrid.SelectedItem != null)
            {
                DoneunDone();
            }
        }
        void DoneunDone()
        {
            MyTask myTask = (MyTask)DayDataGrid.SelectedItem;
            if (myTask.status == Status.Undone)
            {
                Manager.tasks.Remove((MyTask)DayDataGrid.SelectedItem);
                myTask.status = Status.Done;
                Manager.tasks.Add(myTask);
            }
            else
            {
                Manager.tasks.Remove((MyTask)DayDataGrid.SelectedItem);
                myTask.status = Status.Undone;
                Manager.tasks.Add(myTask);
            }
        }

        private void Undo_click(object sender, RoutedEventArgs e)
        {
            Manager.Undo();
            DayDataGrid.ItemsSource = Manager.tasks;
        }

        private void Redo_click(object sender, RoutedEventArgs e)
        {
            Manager.Redo();
            DayDataGrid.ItemsSource = Manager.tasks;
        }
    }
    
}
