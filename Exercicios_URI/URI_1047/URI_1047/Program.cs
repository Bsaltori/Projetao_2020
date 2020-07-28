using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string[] num = Console.ReadLine().Split();
            int horInicial = int.Parse(num[0]);
            int minutoInicial = int.Parse(num[1]);
            int horaFinal = int.Parse(num[2]);
            int minutoFinal = int.Parse(num[3]);

            int inicial = horInicial * 60 + minutoInicial;
            int final = horaFinal * 60 + minutoFinal;

            int duracao;
            if (inicial < final)
            {
                duracao = final - inicial;
            }
            else
            {
                duracao = (24 * 60 - inicial) + final;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}
