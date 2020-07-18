using System;
using System.Globalization;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura");
            string[] cont = Console.ReadLine().Split(' ');
            string n = cont[0];
            int idade = int.Parse(cont[1]);
            double altura = double.Parse(cont[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
    
            Console.WriteLine(quartos);
        
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
          
            Console.WriteLine(n);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));
          
            



        }
    }
}
