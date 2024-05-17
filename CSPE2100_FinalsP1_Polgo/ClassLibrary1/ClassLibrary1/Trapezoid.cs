using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Trapezoid : Class1
    {
        public override double Calculate(double lbase, double sbase, double height)
        {
            double area = (0.5 * (lbase + sbase)) * height;
            return area;  
        }
    }
}
