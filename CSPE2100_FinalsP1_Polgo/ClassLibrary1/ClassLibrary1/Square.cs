using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Square : Class1
    {
        
        public override double Calculate(double side, double y, double z)
        {
            double area = side * side;
            return area;
        }
    }
}
