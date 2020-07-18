using System;
using System.IO.Pipes;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int idadeDias = int.Parse(Console.ReadLine());

            int meses, dias, anos, resto;

            anos = idadeDias / 365;
            Console.WriteLine(anos + " ano(s)");
            resto = idadeDias % 365;


            meses = resto / 30;
            Console.WriteLine(meses + " mes(es)");

            dias = resto % 30;            
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
