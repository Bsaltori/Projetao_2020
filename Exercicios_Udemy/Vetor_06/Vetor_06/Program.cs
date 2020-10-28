using System;

namespace Vetor_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];

            string[] X = Console.ReadLine().Split(" ");
            for(int i =0; i<N; i++)
            {
                A[i] = int.Parse(X[i]);
            }

            string[] Y = Console.ReadLine().Split(" ");
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(Y[i]);
            }

            int[] C = new int[N];

            int soma = A[0] + B[0];




            for (int i = 0; i<N; i++)
            {
                soma = A[i] + B[i];
                C[i] = soma;
                

                Console.Write(C[i] + " ");
               
                
            }

            
        }
           
    }
}
