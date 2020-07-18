using System;

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);

            

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");

            }else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
