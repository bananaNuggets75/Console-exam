using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : Class1
    {
        public override double Calculate(double base1, double height, double z)
        {
            double area = 0.5 * (base1 * height) ;
            return area ; 
        }
    }
}
