using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 2;

            for(int i = 0; i < 5 ;i += 1)
            {
                total = total * 2;
            }
            Console.Write("O total é:" + total);
            Console.ReadKey();
        }
    }
}
