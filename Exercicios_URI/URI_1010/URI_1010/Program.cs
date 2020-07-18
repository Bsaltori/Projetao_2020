using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] prod1 = Console.ReadLine().Split(' ');

            int A = int.Parse(prod1[0]);
            int B = int.Parse(prod1[1]);
            double C = double.Parse(prod1[2], CultureInfo.InvariantCulture);

            string[] prod2 = Console.ReadLine().Split(' ');

            int A1 = int.Parse(prod2[0]);
            int B1 = int.Parse(prod2[1]);
            double C1 = double.Parse(prod2[2], CultureInfo.InvariantCulture);

            double calculo1, calculo2, resultado;
            calculo1 = B * C;
            calculo2 = B1 * C1;
            resultado = calculo1 + calculo2;

            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
