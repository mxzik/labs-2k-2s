using _7_8laba.Mod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _7_8laba
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Model> _todoData;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonRed(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonList(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentDate_Loaded(object sender, RoutedEventArgs e)
        {
            _todoData = new BindingList<Model>()
            {
                new Model(){Text = "text"},
                new Model(){Text = "12312"}
            }
        }
    }
}
