using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrado_inteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;

            Console.Write("Informe um número: ");
            n = int.Parse(Console.ReadLine());

            r = n * n;

            Console.Write("O quadrado do número é: " + r);

            Console.ReadKey();

  
        }
    }
}
