using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public class Circle : Figure
    {
        new public string _name { get; set; } = "Круг";
        public double _radiusX { get; protected set;}
        public Pen _pen { get; set; }

        public Circle(double radius) 
        {
            _xPosition = 100;
            _yPosition = 100;
            SetRadius(radius);
        }

        public Circle(double radius, double xPosition, double yPosition)
        {
            _xPosition = xPosition;
            _yPosition = yPosition;
            SetRadius(radius);
        }

        public void SetRadius(double value)
        {
            if (value > 0)
            {
                _radiusX = value;
            }
            else
            {
                throw new System.Exception("Радиус не может быть меньше или равняться 0.");
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(_brush,_pen,new System.Windows.Point(_xPosition,_yPosition),_radiusX, _radiusX);
        }
    }
}
