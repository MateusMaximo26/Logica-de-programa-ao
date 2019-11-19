using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {//1 a 60 de dois em dois

            int x = 1;

            for (x=1; x <=60; x++)
            {
                if(x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();

        }
    }
}
