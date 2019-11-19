using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1, ate;

            Console.Write("Informe um numero: ");
            n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                Console.Write("\n" + i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
