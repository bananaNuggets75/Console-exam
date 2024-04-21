
using System;


namespace CSPE2100_MidtermP1_Polgo
{
    internal class Rhombus : Polygon
    {
        private double diag1, diag2;

        public Rhombus(double diag1, double diag2)
        {
            this.diag1 = diag1;
            this.diag2 = diag2;
            this.area = (diag1 * diag2) / 2;
        }
    }
}
