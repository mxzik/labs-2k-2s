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

namespace usercontrol
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public object Open
        {
            get { return (object)GetValue(OpenProperty); }
            set { SetValue(OpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Open.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OpenProperty =
            DependencyProperty.Register("Open", typeof(object), typeof(UserControl1), new PropertyMetadata(0));

        private void Spoiler_Click(object sender, RoutedEventArgs e)
        {
            if (Spoiler.Visibility == Visibility.Visible)
            {
                Content.Visibility = Visibility.Visible;
                Spoiler.Visibility = Visibility.Hidden;
            }
            else
            {
                Content.Visibility = Visibility.Hidden;
                Spoiler.Visibility = Visibility.Visible;
            }
        }
    }
}
