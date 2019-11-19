using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contagem
{
    class Program
    {
        static void Main(string[] args)
        {//imprime os numeros inteiros 10 a 1
            int X;

            for (X = 10; X >= 1; X--)
            {
                Console.WriteLine("Contagem regressiva: " + X);
            }
            Console.ReadKey();
        }
        
    }
}
