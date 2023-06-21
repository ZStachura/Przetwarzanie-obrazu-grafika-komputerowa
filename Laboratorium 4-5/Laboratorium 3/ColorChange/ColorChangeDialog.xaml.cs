using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laboratorium_4_5.ColorChange
{
    /// <summary>
    /// Logika interakcji dla klasy ColorChangeDialog.xaml
    /// </summary>
    public partial class ColorChangeDialog : Window
    {
        public ColorChangeDialog()
        {
            InitializeComponent();
            RedValue.Text = Color.R.ToString();
            GreenValue.Text = Color.G.ToString();
            BlueValue.Text = Color.B.ToString();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CloseDialog(object sender, RoutedEventArgs e)
        {
            Color.R = (byte)Int32.Parse(RedValue.Text);
            Color.G = (byte)Int32.Parse(GreenValue.Text);
            Color.B = (byte)Int32.Parse(BlueValue.Text);
            this.Close();
        }

        private double Saturation(double c_max, double delta)
        {
            return c_max == 0 ? 0 : delta / c_max;
        }

        private double Hue(double delta, double c_max, double red_prim, double green_prim, double blue_prim, double degree)
        {
            if (delta == 0)
            {
                return 0;
            }
            else if (c_max == red_prim)
            {
                return degree * ((green_prim - blue_prim) / delta);
            }
            else if (c_max == green_prim)
            {
                return degree * ((blue_prim - red_prim) / delta);
            }
            else if (c_max == blue_prim)
            {
                return degree * ((red_prim - green_prim) / delta);
            }
            return 0;
        }

        private void ValueChange(object sender, TextChangedEventArgs e)
        {
            string red_value, green_value, blue_value;
            double red_prim, green_prim, blue_prim;
            double c_max, c_min, delta;
            double hue = 0;
            double sat = 0;
            double degree = 60;

            red_value = RedValue.Text;
            green_value = GreenValue.Text;
            blue_value = BlueValue.Text;

            if (red_value != "" && green_value != "" && blue_value != "" && Double.Parse(red_value) >= 0 && Double.Parse(red_value) <= 255 && Double.Parse(green_value) <= 255 && Double.Parse(blue_value) <= 255)
            {
                red_prim = Double.Parse(red_value) / 255;
                green_prim = Double.Parse(green_value) / 255;
                blue_prim = Double.Parse(blue_value) / 255;

                double[] colors = new double[] { red_prim, green_prim, blue_prim };
                c_max = colors.Max();
                c_min = colors.Min();
                delta = c_max - c_min;

                sat = Saturation(c_max, delta);
                hue = Hue(delta, c_max, red_prim, green_prim, blue_prim, degree);

                Color.S = (int)sat;
                Color.H = (int)hue;
                Color.V = (int)c_max;

                Color.R = (byte)Int32.Parse(red_value);
                Color.G = (byte)Int32.Parse(green_value);
                Color.B = (byte)Int32.Parse(blue_value);

                SaturationValue.Text = Color.S.ToString();
                HueValue.Text = Color.H.ToString();
                ValueValue.Text = Color.V.ToString();

            }
            else
            {
                SaturationValue.Text = "";
                HueValue.Text = "";
                ValueValue.Text = "";
            }
        }
    }
}
