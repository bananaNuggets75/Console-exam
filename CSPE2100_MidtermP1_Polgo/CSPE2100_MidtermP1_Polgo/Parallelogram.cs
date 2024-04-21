using System;

namespace CSPE2100_MidtermP1_Polgo
{
    internal class Parallelogram : Polygon
    {
        private double paraBase, height;
        public Parallelogram(double paraBase, double height)
        {
            this.paraBase = paraBase;
            this.height = height;
            this.area = paraBase * height;
        }
    }
}
