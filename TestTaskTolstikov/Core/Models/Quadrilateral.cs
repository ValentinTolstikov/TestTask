using System.Windows;
using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public class Quadrilateral : Figure
    {
        new public string _name { get; } = "Четырехугольник";

        public Point _pA { get; set; }
        public Point _pB { get; set; }
        public Point _pC { get; set; }
        public Point _pD { get; set; }

        private Pen _pen;

        public Quadrilateral(Point a, Point b, Point c, Point d) 
        {
            _pA = a;
            _pB = b;
            _pC = c;
            _pD = d;
            _pen = new Pen(_brush,1.0);
        }

        public Quadrilateral(Point a, Point b, Point c, Point d,Pen pen)
        {
            _pA = a;
            _pB = b;
            _pC = c;
            _pD = d;
            _pen = pen;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawLine(_pen, _pA, _pB);
            drawingContext.DrawLine(_pen, _pB, _pC);
            drawingContext.DrawLine(_pen, _pC, _pD);
            drawingContext.DrawLine(_pen, _pD, _pA);
        }
    }
}
