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
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int[] mult = new int[10];
            int i;//contador de for

            //inserindo valores no vetor A
            Console.Write("Inserindo valores no vetor A***\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            //multiplicação dos vetores
            Console.Write("Os valores do vetor B***\n");
            Console.WriteLine("Impressão do vetor: ");
            for (i = 0; i < 10; i++)
            {
                mult[i] = A[i] * A[i];
                //Os valores são referenciados na memoria Ram como sendo {0},{1}e{2}
                Console.WriteLine("B = [{2}] ", A[i], B[i], mult[i]);
            }

            //Finaliza
            Console.ReadKey();
        }
    }
}
