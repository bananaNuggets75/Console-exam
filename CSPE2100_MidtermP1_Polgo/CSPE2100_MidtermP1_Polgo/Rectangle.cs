using System;

namespace CSPE2100_MidtermP1_Polgo
{
    class Rectangle : Polygon
    {
        private double length, width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            this.area = length * width;
        }



    }
}