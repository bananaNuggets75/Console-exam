using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Hexagon : Class1
    {
        public override double Calculate(double side, double y, double z)
        {
            double area = ((3 * Math.Sqrt(3)) * 0.5 * (side * side)); 
            return area;    
        }
    }
}
