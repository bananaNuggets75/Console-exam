
using System;


namespace CSPE2100_MidtermP1_Polgo
{
    internal class Pentagon : Polygon
    {
        private double perimeter, apothem;

        public Pentagon(double perimeter, double apothem)
        {
            this.perimeter = perimeter;
            this.apothem = apothem;
            this.area = (perimeter * apothem) / 2;
        }
    }
}
