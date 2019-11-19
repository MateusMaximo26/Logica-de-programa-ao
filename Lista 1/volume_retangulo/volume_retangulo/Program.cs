using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, c, l, a;

            Console.Write("Entre com o valor do comprimento: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Entre com o valor da largura: ");
            l = double.Parse(Console.ReadLine());

            Console.Write("Entre com o valor da altura: ");
            a = double.Parse(Console.ReadLine());

            v = c * l * a;

            Console.Write("O volume é: " + v);

            Console.ReadKey();
      
        }
    }
}
