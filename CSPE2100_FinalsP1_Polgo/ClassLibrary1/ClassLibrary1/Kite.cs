using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Kite : Class1
    {
        public override double Calculate(double diag1, double diag2, double z)
        {
            double area = (diag1 * diag2) / 2;
            return area;
        }
    }
}
