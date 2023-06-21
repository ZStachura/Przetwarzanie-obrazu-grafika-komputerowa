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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laboratorium_2
{
    public partial class MainWindow : Window
    {
        Point currentPoint = new Point();
        Models.Line drawLine = new Models.Line();
        private bool rubberActive = false;
        private bool squareActive = false;
        private bool circleActive = false;
        private bool lineActive = false;
        
        private bool dragLine = false;
        private bool drag = false;

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
                    Fill = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233))),
                    Stroke = Brushes.Black
                };

                paintSurface.Children.Add(rectangle);

                rectangle.SetValue(Canvas.LeftProperty, currentPoint.X);
                rectangle.SetValue(Canvas.TopProperty, currentPoint.Y);
            }

            if (this.circleActive)
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
            if (this.lineActive) 
            {
                if(this.drawLine.pos1)
                {
                    this.drawLine.x1 = currentPoint.X;
                    this.drawLine.y1 = currentPoint.Y;
                    this.drawLine.pos1 = false;
                }
                else
                {
                    Line line = new Line();
                    line.Stroke = SystemColors.WindowFrameBrush;
                    line.StrokeThickness = 5;
                    line.X1 = this.drawLine.x1;
                    line.Y2 = this.drawLine.y1;
                    line.X2 = currentPoint.X;
                    line.Y2 = currentPoint.Y;
                    line.MouseDown += new MouseButtonEventHandler(Line_MouseDown);
                    line.MouseMove += new MouseEventHandler(Line_MouseMove);
                    line.MouseUp += new MouseButtonEventHandler(Line_MouseUp);

                    paintSurface.Children.Add(line);
                    this.drawLine.pos1 = true;
                }
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

                    if (e.OriginalSource is Rectangle)
                    {
                        Rectangle activeRectangle = (Rectangle)e.OriginalSource;

                        paintSurface.Children.Remove(activeRectangle);
                    }
                    if (e.OriginalSource is Ellipse)
                    {
                        Ellipse activeCircle = (Ellipse)e.OriginalSource;

                        paintSurface.Children.Remove(activeCircle);
                    }
                }
                if (!this.rubberActive && !this.squareActive && !this.circleActive &&!this.drag &&!dragLine)
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

        private void Line_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            Line line = (Line)sender;

            currentPoint = e.GetPosition(paintSurface);

            if (currentPoint.X > line.X1 - 25 && currentPoint.X < line.X1 + 25 &&
                currentPoint.Y > line.Y1 - 25 && currentPoint.Y < line.Y1 + 25)
            {
                dragLine = true;
                drag = true;
            }

            if (currentPoint.X > line.X2 - 25 && currentPoint.X < line.X2 + 25 &&
                currentPoint.Y > line.Y2 - 25 && currentPoint.Y < line.Y2 + 25)
            {
                dragLine = true;
                drag = false;
            }
        }

        private void Line_MouseMove(object sender, MouseEventArgs e)
        {
            Line line = (Line)sender;
            if (dragLine == true && e.LeftButton == MouseButtonState.Pressed)
            {
                if (drag)
                {
                    line.X1 += (e.GetPosition(paintSurface).X - currentPoint.X) / 2;
                    line.Y1 += (e.GetPosition(paintSurface).Y - currentPoint.Y) / 2;
                }
                else
                {
                    line.X2 += (e.GetPosition(paintSurface).X - currentPoint.X) / 2;
                    line.Y2 += (e.GetPosition(paintSurface).Y - currentPoint.Y) / 2;
                }
            }
        }

        private void Line_MouseUp(object sender, MouseButtonEventArgs e)
        {
            dragLine = false;
        }

        private void FreeDraw(object Sender, EventArgs e)
        {
            this.rubberActive = false;
            this.squareActive = false;
            this.circleActive = false;
            this.dragLine = false;
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
                this.circleActive = false;
                this.lineActive = false;
                this.dragLine = false;
            }
        }

        private void Circle(object Sender, EventArgs e)
        {
            if (this.circleActive)
            {
                this.circleActive = false;
            }
            else
            {
                this.circleActive = true;
                this.rubberActive = false;
                this.squareActive = false;
                this.lineActive = false;
                this.dragLine = false;
            }
        }

        private void Line(object Sender, EventArgs e)
        {
            if(this.lineActive) 
            {
                this.lineActive = false;
            }
            else
            {
                this.lineActive = true;
                this.circleActive = false;
                this.rubberActive = false;
                this.squareActive = false;
                this.dragLine = false;
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
                this.squareActive = false;
                this.circleActive = false;
                this.lineActive = false;
                this.dragLine = false;
            }
        }

        private void DragLine(object Sender, EventArgs e)
        {
            if(this.dragLine) 
            { 
                this.dragLine = false;
            }
            else
            {
                this.dragLine = true;
                this.rubberActive = false;
                this.squareActive = false;
                this.circleActive = false;
                this.lineActive = false;
            }
        }

        private void Clear(object Sender, EventArgs e)
        {
            this.rubberActive = false;
            this.squareActive = false;
            this.circleActive = false;
            this.lineActive = false;
            this.dragLine = false;
            paintSurface.Children.Clear();
        }

    }
}
