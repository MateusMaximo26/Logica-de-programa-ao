using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x,soma=0;
            double media;
            for (i = 50; i <=70; i++)
            {
                Console.WriteLine("[{0}º]: "+ i);
                soma = i + soma;
            }
            Console.Write("\nA soma total é:" + soma);
            media = soma / 20;
            Console.Write("\nA media total é:" + media);
            Console.ReadKey();
        }
    }
}
