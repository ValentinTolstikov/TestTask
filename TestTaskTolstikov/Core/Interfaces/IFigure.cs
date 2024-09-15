using System.Windows.Media;

namespace TestTaskTolstikov.Core.Models
{
    public interface IFigure
    {
        string _name { get; }

        double _xPosition { get; set; }
        double _yPosition { get; set; }

        SolidColorBrush _brush { get; set; }
    }
}
