using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            string[] seila = Console.ReadLine().Split(' ');
            string nome = seila[0];
            char sexo = char.Parse(seila[1]);
            int idade = int.Parse(seila[2]);
            double altura = double.Parse(seila[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você escreveu:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
