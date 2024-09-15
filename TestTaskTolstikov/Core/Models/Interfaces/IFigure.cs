using System.Windows.Shapes;

namespace TestTaskTolstikov.Core.Models
{
    public interface IFigure
    {
        string _name { get; }
        Shape Draw();
    }
}
