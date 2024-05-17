using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Parallelogram1 : Class1
    {
        public override double Calculate(double base1, double heigth, double z)
        {
            double area = base1 * heigth;
            return area;
        }
    }
}
