using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;
using TestTaskTolstikov.Core.Models;

namespace TestTaskTolstikov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void tbxCircleRadius_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!IsTextAllowed(e.Text))
            { 
                e.Handled = true;
            }
        }

        private void btnDrawCircle_Click(object sender, RoutedEventArgs e)
        {
            double radius = double.Parse(tbxCircleRadius.Text);
            Circle circle = new Circle(radius, 100, 100);
            cnvCircle.Children.Clear();
            cnvCircle.Children.Add(circle);
        }

        private void btnDrawSquare_Click(object sender, RoutedEventArgs e)
        {
            double size = double.Parse(tbxSquareSize.Text);
            Square square = new Square(size,null,50,50);
            cnvSquare.Children.Clear();
            cnvSquare.Children.Add(square);
        }

        private void btnDrawEllipse_Click(object sender, RoutedEventArgs e)
        {
            double rX = double.Parse(tbxEllipseX.Text);
            double rY = double.Parse(tbxEllipseY.Text);
            Ellipse ellipse = new Ellipse(rX,rY);
            cnvEllipse.Children.Clear();
            cnvEllipse.Children.Add(ellipse);
        }

        private void btnDrawTriangle_Click(object sender, RoutedEventArgs e)
        {
            Point pA = new Point(double.Parse(tbxTriangleAX.Text), double.Parse(tbxTriangleAY.Text));
            Point pB = new Point(double.Parse(tbxTriangleBX.Text), double.Parse(tbxTriangleBY.Text));
            Point pC = new Point(double.Parse(tbxTriangleCX.Text), double.Parse(tbxTriangleCY.Text));
            Pen pen = new Pen(new SolidColorBrush(Colors.Black), 1.0);
            Triangle triangle = new Triangle(pA, pB, pC, pen);
            cnvTriangle.Children.Clear();
            cnvTriangle.Children.Add(triangle);
        }

        private void btnDrawQuad_Click(object sender, RoutedEventArgs e)
        {
            Point pA = new Point(double.Parse(tbxQuadAX.Text), double.Parse(tbxQuadAY.Text));
            Point pB = new Point(double.Parse(tbxQuadBX.Text), double.Parse(tbxQuadBY.Text));
            Point pC = new Point(double.Parse(tbxQuadCX.Text), double.Parse(tbxQuadCY.Text));
            Point pD = new Point(double.Parse(tbxQuadDX.Text), double.Parse(tbxQuadDY.Text));
            Quadrilateral quad = new Quadrilateral(pA, pB, pC, pD, new Pen(new SolidColorBrush(Colors.Black),1.0));
            cnvQuad.Children.Clear();
            cnvQuad.Children.Add(quad);
        }
    }
}
