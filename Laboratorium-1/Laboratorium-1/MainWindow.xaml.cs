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

namespace Laboratorium_1
{
    public partial class MainWindow : Window
    {
        Point currentPoint = new Point();
        private bool rubberActive = false;
        private bool squareActive = false;
        private bool circleActive = false;

        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Canvas_MouseDown_1(object sender,
       System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(this);

            if (this.squareActive)
            {

                Rectangle rectangle = new Rectangle()
                {
                    Width = 50,
                    Height = 50,
                    StrokeThickness = 3,
                    Fill = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),(byte)r.Next(1, 255), (byte)r.Next(1, 233))),
                    Stroke = Brushes.Black
                };

                paintSurface.Children.Add(rectangle);

                rectangle.SetValue(Canvas.LeftProperty, currentPoint.X);
                rectangle.SetValue(Canvas.TopProperty, currentPoint.Y);
            }

            if(this.circleActive)
            {
                Ellipse circle = new Ellipse()
                {
                    Width = 50,
                    Height = 50,
                    StrokeThickness = 3,
                    Fill = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233))),
                    Stroke = Brushes.Black
                };

                paintSurface.Children.Add(circle);
                circle.SetValue(Canvas.LeftProperty, currentPoint.X);
                circle.SetValue(Canvas.TopProperty, currentPoint.Y);
            }

        }
        private void Canvas_MouseMove_1(object sender,
       System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (this.rubberActive)
                {
                    if (e.OriginalSource is Line)
                    {
                        Line activeLine = (Line)e.OriginalSource;

                        activeLine.Stroke = SystemColors.WindowFrameBrush;
                        activeLine.X1 = currentPoint.X;
                        activeLine.Y1 = currentPoint.Y;
                        activeLine.X2 = e.GetPosition(this).X;
                        activeLine.Y2 = e.GetPosition(this).Y;
                        currentPoint = e.GetPosition(this);

                        paintSurface.Children.Remove(activeLine);
                    }

                    if(e.OriginalSource is Rectangle) 
                    {
                        Rectangle activeRectangle=(Rectangle)e.OriginalSource;

                        paintSurface.Children.Remove(activeRectangle);
                    }
                    if(e.OriginalSource is Ellipse)
                    {
                        Ellipse activeCircle=(Ellipse)e.OriginalSource;

                        paintSurface.Children.Remove(activeCircle);
                    }
                }
                if (!this.rubberActive && !this.squareActive && !this.circleActive)
                {
                    Line line = new Line();
                    line.Stroke = SystemColors.WindowFrameBrush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;
                    currentPoint = e.GetPosition(this);
                    paintSurface.Children.Add(line);
                }
            }
        }

        private void FreeDraw(object Sender, EventArgs e)
        {
            this.rubberActive = false;
            this.squareActive = false;
            this.circleActive = false;
        }

        private void Square(object Sender, EventArgs e)
        {
            if (this.squareActive)
            {
                this.squareActive = false;
            }
            else
            {
                this.squareActive = true;
                this.rubberActive = false;
                this.circleActive=false;
            }
        }

        private void Circle(object Sender, EventArgs e)
        {
            if(this.circleActive)
            {
                this.circleActive = false;
            }
            else
            {
                this.circleActive = true;
                this.rubberActive = false;
                this.squareActive=false;
            }
        }

        private void Rubber(object Sender, EventArgs e)
        {
            if (this.rubberActive)
            {
                this.rubberActive = false;
            }
            else
            {
                this.rubberActive = true;
                this.squareActive= false;
                this.circleActive = false;
            }
        }

        private void Clear(object Sender, EventArgs e)
        {
            this.rubberActive = false;
            this.squareActive = false;
            this.circleActive = false;
            paintSurface.Children.Clear();
        }

    }
}
