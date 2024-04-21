using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSPE2100_MidtermP1_Polgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pili;
            Polygon poly = new Polygon();
            Console.WriteLine(@"Choose a Polygon: (1)Triangle, (2) Rectangle, (3) Square, (4) Parallelogram,
            (5) Rhombus, (6) Trapezoid, (7) Kite, (8) Pentagon");

            pili = Console.ReadLine();
            poly.piliKa(pili);

            Console.ReadLine();

            while (pili == pili) 
            {
                
                Console.WriteLine("HAHAHHAHA ma loop ka asta mapatay, loooool");
                pili = Console.ReadLine();
                poly.piliKa(pili);

            }

            

        }
    }
}
