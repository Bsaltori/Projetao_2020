using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int cem, cinquenta, vinte, dez, cinco, dois, um;
            int resto, N;

            N = int.Parse(Console.ReadLine());

            cem = N / 100;
            resto = N % 100;

            cinquenta = resto / 50;
            resto = resto % 50;

            vinte = resto / 20;
            resto = resto % 20;

            dez = resto / 10;
            resto = resto % 10;

            cinco = resto / 5;
            resto = resto % 5;

            dois = resto / 2;
            resto = resto % 2;

            um = resto / 1;
            resto = resto % 1;



            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");




        }
    }
}
