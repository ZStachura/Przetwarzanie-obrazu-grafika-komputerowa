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
using Emgu.CV;
using Emgu.CV.Structure;

namespace Laboratorium_6
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Image<Bgr, byte> img = new Image<Bgr, byte>("D:\\Images\\image_1.jpg");

            Image<Gray, byte> img_gray = img.Convert<Gray, byte>();
            Image<Gray, Single> img_gray_single = (img_gray.Sobel(1, 0, 5));
            Image<Gray, byte> img_smooth = img_gray.SmoothGaussian(23);


            CvInvoke.Imshow("Original image", img);
            CvInvoke.Imshow("Grey image", img_gray);
            CvInvoke.Imshow("Second gray image", img_gray_single);
            CvInvoke.Imshow("Smooth image", img_smooth);
            CvInvoke.WaitKey(0);
        }
    }
}
