using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_trapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            double bmaior, bmenor, a, area;

            Console.Write("Informe o valor da base maior: ");
            bmaior = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor da base menor: ");
            bmenor = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor da altura: ");
            a = double.Parse(Console.ReadLine());

            area = ((bmaior + bmenor) * a) / 2;

            Console.Write("A area do trapézio é: " + area);

            Console.ReadKey();
        }
    }
}
