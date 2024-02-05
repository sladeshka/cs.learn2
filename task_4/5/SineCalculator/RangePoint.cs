using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SineCalculator
{
    public class RangePoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public RangePoint(double X, double Y) { 
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return $"{X}:{Y}\n";
        }
    }
}
