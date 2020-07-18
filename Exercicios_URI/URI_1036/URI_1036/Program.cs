using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numero = Console.ReadLine().Split(' ');

            double A = double.Parse(numero[0], CultureInfo.InvariantCulture);
            double B = double.Parse(numero[1], CultureInfo.InvariantCulture);
            double C = double.Parse(numero[2], CultureInfo.InvariantCulture);

            double r1, r2, delta;
            delta = Math.Pow(B, 2.0) - 4 * A * C;

            

            if (A == 0.0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                r1 = (-B + Math.Sqrt(delta)) / (2 * A);
                r2 = (-B - Math.Sqrt(delta)) / (2 * A);
                Console.WriteLine("R1 = " + r1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("f5", CultureInfo.InvariantCulture));
            }

            

            
        }
    }
}
