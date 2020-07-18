using System;

namespace URI_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dia ");
            int inicio = int.Parse(Console.ReadLine());

            string[] data1 = Console.ReadLine().Split(' ');

            int horas = int.Parse(data1[0]);
            int minutos = int.Parse(data1[2]);
            int segundos = int.Parse(data1[4]);

            Console.Write("Dia ");
            int fim = int.Parse(Console.ReadLine());

            string[] data2 = Console.ReadLine().Split(' ');

            int horas1 = int.Parse(data2[0]);
            int minutos1 = int.Parse(data2[2]);
            int segundos1 = int.Parse(data2[4]);

            int x, y, duracao, A, B, C, D, resto;
            x = (inicio - 1) * 24 * 60 * 60 + horas * 60 * 60 + minutos * 60 + segundos;
            y = (fim - 1) * 24 * 60 * 60 + horas1 * 60 * 60 + minutos1 * 60 + segundos1;

            duracao = y - x;

            A = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            B = resto / (60 * 60);
            resto = resto % (60 * 60);
            C = resto / 60;
            D = resto % 60;

            Console.WriteLine(A + " dia(s)");
            Console.WriteLine(B + " minutos(s)");
            Console.WriteLine(C + " segundos(s)");



        }
    }
}
