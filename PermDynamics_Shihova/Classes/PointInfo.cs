using System.Windows.Shapes;

namespace PermDynamics_Shihova.Classes
{
    public class PointInfo
    {
        public double value { get; set; }
        public Line line { get; set; }

        public PointInfo(double value)
        {
            this.value = value;
        }
    }
}
