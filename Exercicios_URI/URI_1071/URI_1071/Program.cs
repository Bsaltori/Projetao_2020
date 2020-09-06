using System;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, troca, soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }

            for (x += 1; x < y; x++)
            {
                if (x % 2 != 0)
                {
                    soma = soma + x;
                }
            }

            Console.WriteLine(soma);





        }
    }
}
