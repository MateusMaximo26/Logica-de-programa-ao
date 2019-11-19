using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            int[] B = new int[10];
            int i;//contador de for

            //inserindo valores no vetor A
            Console.Write("Inserindo valores no vetor A***\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                if (i % 2 == 0 && i % 3 == 0)
                {
                    A[i] = int.Parse(Console.ReadLine());
                }
            }

            //inserindo valores no vetor B
            Console.Write("Inserindo valores no vetor B***\n");
            for (i = 0; i < 10; i++)
            {
                if(i % 5 == 0)
                {
                    Console.Write("Digite um número: ");
                    B[i] = int.Parse(Console.ReadLine());
                }
            }

            //Finaliza
            Console.ReadKey();

        }
    }
}
