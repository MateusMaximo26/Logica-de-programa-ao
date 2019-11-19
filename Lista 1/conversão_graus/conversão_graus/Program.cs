using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversão_graus
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.Write("Informe o valor do grau em Fahrenheit: ");
            f = double.Parse(Console.ReadLine());

            c = (f - 32) * 5 / 9;

            Console.Write("O valor em graus Celsius é de: " + c   b6);

            Console.ReadKey();
        }
    }
}
