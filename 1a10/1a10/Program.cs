using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1a10
{
    class Program
    {
        static void Main(string[] args)
        {//imprime de 1 a 10
            int i = 1;

            Console.Write("\nLaco de repetição while/enquanto");
            while (i <= 10)//enquanto
            {
                Console.Write("\n" + i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
