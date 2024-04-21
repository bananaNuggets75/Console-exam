
using System;

namespace CSPE2100_MidtermP1_Polgo
{
    internal class Kite : Polygon
    {
        private double diagonal1, diagonal2;

        public Kite(double diagonal1, double diagonal2)
        {
            this .diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
            this.area = (diagonal1 * diagonal2) / 2;
        }
    }
}
