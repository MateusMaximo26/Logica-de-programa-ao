using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, mf;

            Console.Write("Informe a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            n3 = int.Parse(Console.ReadLine());

            mf = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

            Console.Write("A média final é: " + mf);

            Console.ReadKey();
        }
    }
}
