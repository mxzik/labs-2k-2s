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

namespace _7_8
{
    /// <summary>
    /// Логика взаимодействия для FontSize.xaml
    /// </summary>
    public partial class FontSize : UserControl
    {
        public FontSize()
        {
            InitializeComponent();
        }
        private void Slaidorcik_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Slaidorcik.Value == 0)
            {
                return;
            }
            Label.FontSize = Slaidorcik.Value;
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 1000)  // если больше 1000, возвращаем 1000
                return 1000;
            return currentValue; // иначе возвращаем текущее значение
        }

        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) // если текущее значение от нуля и выше
                return true;
            return false;
        }
    }
}
