
using System;

namespace CSPE2100_MidtermP1_Polgo
{
    internal class Trapezoid : Polygon
    {
        private double longBase, shortBase, height;

        public Trapezoid(double longBase, double shortBase, double height)
        {
            this.longBase = longBase;
            this.shortBase = shortBase;
            this.height = height;

            this.area = ((longBase + shortBase) * height) / 2; 
        }
    }
}
