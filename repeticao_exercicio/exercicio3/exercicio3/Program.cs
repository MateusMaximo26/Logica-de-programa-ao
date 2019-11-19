using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {//de 10 em 10 até 50
            int i;

            for (i = 0; i <=50; i++)
            {
                if(i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}
