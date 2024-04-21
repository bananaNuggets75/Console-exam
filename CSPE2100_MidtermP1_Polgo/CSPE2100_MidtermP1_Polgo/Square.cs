using System;

namespace CSPE2100_MidtermP1_Polgo
{
    class Square : Polygon
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
            this.area = a * a;
        }
    }
}