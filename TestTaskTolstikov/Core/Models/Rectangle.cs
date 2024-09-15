using System.Windows.Shapes;

namespace TestTaskTolstikov.Core.Models
{
    public class Rectangle : IFigure
    {
        public string _name { get; set; }
        public double _xLenght { get; set; }
        public double _yLenght { get; set; }

        public Rectangle(string name, double xLenght, double yLenght) 
        {
            _name = name;
            _xLenght = xLenght;
            _yLenght = yLenght;
        }

        public Shape Draw()
        {
            System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle();
            rectangle.Height = _yLenght;
            rectangle.Width = _xLenght;
            return rectangle;
        }
    }
}
