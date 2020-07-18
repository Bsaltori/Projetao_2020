using System;
using System.Globalization;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo, porcentagem;

            if( salario <= 400.00)
            {
                porcentagem = salario * 15 / 100;
                calculo = salario + porcentagem;
                Console.WriteLine("Novo salario: " + calculo.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + porcentagem.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                porcentagem = salario * 12 / 100;
                calculo = salario + porcentagem;
                Console.WriteLine("Novo salario: " + calculo.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + porcentagem.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                porcentagem = salario * 10 / 100;
                calculo = salario + porcentagem;
                Console.WriteLine("Novo salario: " + calculo.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + porcentagem.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                porcentagem = salario * 7 / 100;
                calculo = salario + porcentagem;
                Console.WriteLine("Novo salario: " + calculo.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + porcentagem.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                porcentagem = salario * 4 / 100;
                calculo = salario + porcentagem;
                Console.WriteLine("Novo salario: " + calculo.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + porcentagem.ToString("f2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
            
        }
    }
}
