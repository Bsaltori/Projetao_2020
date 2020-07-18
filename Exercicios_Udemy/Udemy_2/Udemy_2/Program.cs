using System;

namespace Udemy_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');

            int N1 = int.Parse(numeros[0]);
            int N2 = int.Parse(numeros[1]);
            int N3 = int.Parse(numeros[2]);

            if (N1 < N2 && N1 < N3)
            {
                Console.WriteLine("MENOR = " + N1);
            }
            else if (N2 < N3)
            {
                Console.WriteLine("MENOR = " + N2);
            } else
            {
                Console.WriteLine("MENOR = " + N3);
            }
        }
    }
}
