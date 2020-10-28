using System;

namespace Vetor_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            string[] numeros = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(numeros[i]);
            }

            //numeros pares
            for (int i = 0; i<N; i++)
            {
               if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");

                    }
            }

            Console.WriteLine();

            //quantidade de pares
            int pares = 0;
            for(int i = 0; i<N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    pares = i;
                }
            }

            Console.WriteLine(pares);
            
        }

    }
}
