using System;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] triangulo = Console.ReadLine().Split();
            double a = double.Parse(triangulo[0]);
            double b = double.Parse(triangulo[1]);
            double c = double.Parse(triangulo[2]);

            double temp;

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
           
            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } 


        }
    }
}
