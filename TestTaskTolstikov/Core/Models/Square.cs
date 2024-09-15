using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public class Square : Figure
    {
        new public string _name = "Линия";

        public Pen _pen { get; set; }
        public double _lenght { get; private set; }

        public Square(double lenght) 
        {
            _pen = new Pen(_brush, 1.0);
            SetLenght(lenght);
        }

        public Square(double lenght,Pen pen)
        {
            _pen = pen;
            SetLenght(lenght);
        }

        public Square(double lenght, Pen pen, double xPosition, double yPosition)
        {
            _pen = pen;
            SetLenght(lenght);
            _xPosition = xPosition;
            _yPosition = yPosition;
        }

        public void SetLenght(double value)
        {
            if (value > 0)
            {
                _lenght = value;
            }
            else
            {
                throw new System.Exception("Длинна не может быть отрицательной.");
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(_brush, _pen, new System.Windows.Rect(_xPosition,_yPosition,_lenght,_lenght));
        }
    }
}
