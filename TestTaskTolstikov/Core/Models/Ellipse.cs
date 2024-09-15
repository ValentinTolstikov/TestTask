using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public class Ellipse : Circle
    {
        new public string _name { get; } = "Элипс";
        public double _radiusY { get; private set; }

        public Ellipse(double radiusX, double RadiusY):base(radiusX)
        {
            SetRadius(radiusX);
            SetRadiusY(RadiusY);
        }

        public Ellipse(double radiusX,double radiusY, double xPosition, double yPosition):base(radiusX,xPosition,yPosition)
        {
            SetRadiusY(radiusY);
        }

        public void SetRadiusY(double value)
        {
            if (value > 0)
            {
                _radiusY = value;
            }
            else
            {
                throw new System.Exception("Радиус не может быть меньше или равняться 0.");
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(_brush, _pen, new System.Windows.Point(_xPosition, _yPosition), _radiusX, _radiusY);
        }
    }
}
