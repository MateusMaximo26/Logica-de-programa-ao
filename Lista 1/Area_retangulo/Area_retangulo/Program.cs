using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, area;

            Console.Write("Informe a medida da base: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Informe a medida da altura: ");
            h = double.Parse(Console.ReadLine());

            area = b * h;

            Console.Write("A area do retangulo é: " + area);

            Console.ReadKey();
        }
    }
}
