﻿using System;
using System.Globalization;

namespace Exercicio_do
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("f1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n) ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
        }
    }
}
