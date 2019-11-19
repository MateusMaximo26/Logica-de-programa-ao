using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, r, a;

            Console.Write("Entre com o valor do raio: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor da altura: ");
            a = double.Parse(Console.ReadLine());

            v = 3.14159 * (r*r) * a;

            Console.Write("O volume é: " + v);

            Console.ReadKey();
        }
    }
}
