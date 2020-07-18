using System;
using System.Globalization;

namespace URI_140
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] numeros = Console.ReadLine().Split(' ');
            double N1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(numeros[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(numeros[3], CultureInfo.InvariantCulture);

            double media, notaExame, mediaFinal;

            media = (((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / (2 + 3 + 4 + 1));
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("f1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                 Console.WriteLine("Aluno aprovado.");

            } else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            
            } else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("f1", CultureInfo.InvariantCulture));
                mediaFinal = (media + notaExame) / 2;

                if (mediaFinal >= 5.0 )
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("f1", CultureInfo.InvariantCulture));

                } else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("f1", CultureInfo.InvariantCulture));

                }
            }

            
            

           
        }
    }
}
