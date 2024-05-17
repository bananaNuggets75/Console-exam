using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rectangle1 : Class1
    {
        public override double Calculate(double width, double lenght, double z)
        {
            double area = width * lenght;
            return area;
        }
    }
}
