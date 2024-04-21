using System;

namespace CSPE2100_MidtermP1_Polgo
{
    class Polygon
    {
        public double area { get; set; }

        public void piliKa(string pili)
        {

            switch (pili)
            {
                case "1":
                    double triBase, height;
                    Console.WriteLine("Enter Base: ");
                    triBase = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height: ");
                    height = int.Parse(Console.ReadLine());
                    Triangle tri = new Triangle(triBase, height);
                    Console.WriteLine("The Area is {0}", tri.area);
                    break;

                case "2":
                    double length, width;
                    Console.WriteLine("Enter Length: ");
                    length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width: ");
                    width = int.Parse(Console.ReadLine());
                    Rectangle rec = new Rectangle(length, width);
                    Console.WriteLine("The Area is {0}", rec.area);
                    break;

                case "3":
                    double a;
                    Console.WriteLine("Enter Length: ");
                    a = int.Parse(Console.ReadLine());
                    Square sqr = new Square(a);
                    Console.WriteLine("The Area is {0}", sqr.area);
                    break;

                case "4":
                    double paraBase, height1;
                    Console.WriteLine("Enter Base: ");
                    paraBase = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height: ");
                    height1 = int.Parse(Console.ReadLine());
                    Parallelogram para = new Parallelogram(paraBase, height1);
                    Console.WriteLine("The Area is {0}", para.area);
                    break;

                case "5":
                    double diag1, diag2;
                    Console.WriteLine("Enter Length: ");
                    diag1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width: ");
                    diag2 = int.Parse(Console.ReadLine());
                    Rhombus rho = new Rhombus(diag1, diag2);
                    Console.WriteLine("The Area is {0}", rho.area);
                    break;

                case "6":
                    double longBase, shortBase, height2;
                    Console.WriteLine("Enter Long Base: ");
                    longBase = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Short Base: ");
                    shortBase = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height: ");
                    height2 = int.Parse(Console.ReadLine());
                    Trapezoid tra = new Trapezoid(longBase, shortBase, height2);
                    Console.WriteLine("The Area is {0}", tra.area);
                    break;


                case "7":
                    double diagonal1, diagonal2;
                    Console.WriteLine("Enter Length: ");
                    diagonal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width: ");
                    diagonal2 = int.Parse(Console.ReadLine());
                    Kite kite = new Kite(diagonal1, diagonal2);
                    Console.WriteLine("The Area is {0}", kite.area);
                    break;

                case "8":
                    double perimeter, apothem;
                    Console.WriteLine("Enter Perimeter: ");
                    perimeter = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Apothem: ");
                    apothem = int.Parse(Console.ReadLine());
                    Pentagon penta = new Pentagon(perimeter, apothem);
                    Console.WriteLine("The Area is {0}", penta.area);
                    break;

                default:
                    throw new ArgumentException("Invalid polygon type");
            }
        }
    }
}