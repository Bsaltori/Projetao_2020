using System;
using System.Globalization;

namespace Udemy_1
{
    class Program
    {
        static void Main(string[] args)
        {
           double nota1, nota2, resultado=0.0;
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = nota1 + nota2;

            if (resultado < 60)
            {
                Console.WriteLine("NOTA FINAL = " + resultado.ToString("f1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");

            } else
            {
                Console.Write("NOTA FINAL = " + resultado.ToString("f1", CultureInfo.InvariantCulture));
            }

            
            



        }
    }
}
