using System.Windows;
using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public abstract class Figure : UIElement, IFigure
    {
        public string _name { get; set; }
        public SolidColorBrush _brush { get; set; } = new SolidColorBrush(Colors.Black);

        public double _xPosition { get; set; }
        public double _yPosition { get; set; }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
        }
    }
}
