using System.Windows;
using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public class Triangle : Figure
    {
        new public string _name { get; } = "Треугольник";

        public Point _pA { get; set; }
        public Point _pB { get; set; }
        public Point _pC { get; set; }

        public Pen _pen { get; set; }

        public Triangle(Point a, Point b, Point c,Pen pen)
        {
            _pA = a;
            _pB = b;
            _pC = c;
            _pen = pen;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawLine(_pen, _pA, _pB);
            drawingContext.DrawLine(_pen, _pB, _pC);
            drawingContext.DrawLine(_pen, _pC, _pA);
        }
    }
}
