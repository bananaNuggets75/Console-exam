using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pentagon : Class1
    {
        public override double Calculate(double para, double apo, double z)
        {
            double area = 0.5 * (para * apo );
            return area;
        }
    }
}
