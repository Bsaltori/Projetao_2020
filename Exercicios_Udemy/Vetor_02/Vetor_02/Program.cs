using System;
using System.Globalization;

namespace Vetor_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

            }
            for (int i=0; i<N; i++)
            {
                Console.Write(A[i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double soma = 0.0;

            for (int i=0; i< N; i++)
            {
                soma = soma + A[i];
            }

            double media = soma / N;

            Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
          



        }
    }
}
