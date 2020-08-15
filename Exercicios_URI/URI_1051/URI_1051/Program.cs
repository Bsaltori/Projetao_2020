using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1051
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario, impostoRenda;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (salario < 2000.00)
            {
                Console.WriteLine("Insento");

            }else if (salario > 2000.01 && salario < 3000.00)
            {
                salario -= 2000.00;
                impostoRenda = salario * 0.08;
                Console.WriteLine("R$ " + impostoRenda.ToString("f2", CultureInfo.InvariantCulture));

            } else
            {
                
                impostoRenda = (salario - 2000.00) * 0.08 +  2.00 * 0.18;
                Console.WriteLine("R$ " + impostoRenda.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
