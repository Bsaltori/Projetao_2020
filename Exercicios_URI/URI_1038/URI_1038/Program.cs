using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.0;

            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;

            } else if (codigo == 3)
            {
                total = quantidade * 5.0;

            } else if (codigo == 4)
            {
                total = quantidade * 2.0;

            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

            }
        }
    }

