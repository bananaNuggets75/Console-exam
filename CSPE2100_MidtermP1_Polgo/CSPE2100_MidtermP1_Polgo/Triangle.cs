using System;

namespace CSPE2100_MidtermP1_Polgo
{
    class Triangle : Polygon
    {
        private double triBase, height;

        public Triangle(double triBase, double height)
        {
            this.triBase = triBase;
            this.height = height;
            this.area = (triBase * height) / 2;
        }
    }
}