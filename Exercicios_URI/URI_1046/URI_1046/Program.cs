using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jogo = Console.ReadLine().Split(' ');
            int inicio = int.Parse(jogo[0]);
            int fim = int.Parse(jogo[1]);

            int duracao;
            if ( inicio < fim)
            {
                duracao = inicio - fim;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)"); 

        }
    }
}
