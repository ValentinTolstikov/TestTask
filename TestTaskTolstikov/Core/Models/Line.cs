using System.Windows;
using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public class Line : Figure
    {
        new public string _name = "Линия";

        public Point _pointA {  get; set; }
        public Point _pointB { get; set; }

        private Pen _pen;

        public Line(Point pointA, Point pointB) 
        {
            _pointA = pointA;
            _pointB = pointB;
        }

        public Line(Point pointA, Point pointB,Pen pen)
        {
            _pointA = pointA;
            _pointB = pointB;
            _pen = pen;
        }

        public override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawLine(_pen, _pointA, _pointB);
        }
    }
}
