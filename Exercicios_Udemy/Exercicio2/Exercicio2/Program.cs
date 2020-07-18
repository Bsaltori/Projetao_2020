using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + preco.ToString("f2", CultureInfo.InvariantCulture));



        }
    }
}
