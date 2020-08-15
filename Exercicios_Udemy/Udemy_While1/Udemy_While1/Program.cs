using System;
using System.Globalization;

namespace Udemy_While1
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            cont = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (cont == 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

            }



        }
    }
}
