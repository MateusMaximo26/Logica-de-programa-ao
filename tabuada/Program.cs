using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {//tabuada de um valor qualquer
            int i, num, r = 0; //i para contador e num para tabuada

            Console.Write("Informe qual tabuada deseja criar: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Tabuada do número{0}", num);

            for(i = 1; i <= 10; i++)
            {
                r = num * i;

                Console.Write("\n" + num + " X " + i + " = " + r + "\n");
            }
            Console.ReadKey();
        }
    }
}
