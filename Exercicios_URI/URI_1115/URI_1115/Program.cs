using System;


namespace URI_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coor = Console.ReadLine().Split(' ');
            int x = int.Parse(coor[0]);
            int y = int.Parse(coor[1]);

            while (x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }else if(x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }else if(x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                coor = Console.ReadLine().Split(' ');
                x = int.Parse(coor[0]);
                y = int.Parse(coor[1]);
            }

        }
    }
}
