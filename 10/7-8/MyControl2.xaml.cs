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
    /// Логика взаимодействия для MyControl2.xaml
    /// </summary>
    public partial class MyControl2 : UserControl
    {

        public MyControl2()
        {
            InitializeComponent();
        }
        public int sost = 1;
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n");
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n");
        }

        private void ColorChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sost != 0)
            {
                sost = 1;
                Color color = Color.FromRgb((byte)(int)sliderRed.Value,0, 0);
                Rectt.Background = new SolidColorBrush(color);
                sost = 1;
                Depend col = (Depend)this.Resources["Colo"];
                col.Slider1 = (int)sliderRed.Value + "";
                sost = 2;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sost != 1)
            {
                sost = 0;
                Depend col = (Depend)this.Resources["Colo"];
                if (Text.Text == "") Text.Text = "0";
                sliderRed.Value = double.Parse(Text.Text);
                Color color = Color.FromRgb((byte)(int)sliderRed.Value, 0, 0);
                Rectt.Background = new SolidColorBrush(color);
                sost = 2;
            }

        }
    }
    public class Depend : DependencyObject
    {
        public static readonly DependencyProperty Slider1Property;


        static Depend()
        {
            PropertyMetadata metadata = new PropertyMetadata
            {
                DefaultValue = "0",
                CoerceValueCallback = new CoerceValueCallback(CorrectValue)
            };


            //metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            Slider1Property = DependencyProperty.Register("Slider1", typeof(string), typeof(Depend), metadata,
            new ValidateValueCallback(ValidateValue));

        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            if (baseValue != null)
            {
                int currentValue = int.Parse((string)baseValue);
                if (currentValue > 255)
                    return "255";
                if (currentValue < 0) return "0";
            }
            return baseValue; // иначе возвращаем текущее значение
        }
        private static bool ValidateValue(object value)
        {
            if (value != null)
            {
                int currentValue = int.Parse((string)value);
                if (currentValue >= 0 && currentValue <= 255) // если текущее значение от нуля и выше
                    return true;
            }
            return false;

        }
        public string Slider1
        {
            get { return (string)GetValue(Slider1Property); }
            set { SetValue(Slider1Property, value); }
        }

    }


}
       

