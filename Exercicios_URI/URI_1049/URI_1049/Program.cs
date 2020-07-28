using System;


namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {

            String tipo1 = Console.ReadLine();
            String tipo2 = Console.ReadLine();
            String tipo3 = Console.ReadLine();

            if (tipo1 == "vertebrado" && tipo2 == "ave" && tipo3 == "carnivoro")
            {
                Console.WriteLine("aguia");

            } else if (tipo1 == "vertebrado" && tipo2 == "ave" && tipo3 == "onivoro")
            {
                Console.WriteLine("pomba");

            } else if (tipo1 == "vertebrado" && tipo2 == "mamifero" && tipo3 == "onivoro")
            {
                Console.WriteLine("homem");

            } else if (tipo1 == "vertebrado" && tipo2 == "mamifero" && tipo3 == "herbivoro")
            {
                Console.WriteLine("vaca");

            }else if (tipo1 == "invertebrado" && tipo2 == "inseto" && tipo3 == "hematofago")
            {
                Console.WriteLine("pulga");

            }else if (tipo1 == "invertebrado" && tipo2 == "inseto" && tipo3 == "herbivoro")
            {
                Console.WriteLine("lagarta");

            }else if (tipo1 == "invertebrado" && tipo2 == "anelideo" && tipo3 == "hematofogo")
            {
                Console.WriteLine("sanguessuga");

            }
            else
            {
                Console.WriteLine("minhoca");
            }

        }

    }
}
