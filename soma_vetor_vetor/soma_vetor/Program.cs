using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];
            int[] Soma = new int[5];
            int i;//contador de for

            //inserindo valores no vetor A
            Console.Write("Inserindo valores no vetor A***\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            //inserindo valores no vetor B
            Console.Write("Inserindo valores no vetor B***\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            //Soma dos vetores
            Console.Write("Soma dos vetores vetor Soma***\n");
            Console.WriteLine("Impressão do vetor: ");
            for (i = 0; i < 5; i++)
            {
                Soma[i] = A[i] + B[i];
                //Os valores são referenciados na memoria Ram como sendo {0},{1}e{2}
                Console.WriteLine("A[{0}] + B[{1}] = Soma[{2}] ", A[i], B[i], Soma[i]);
            }

            //Finaliza
            Console.ReadKey();
        }
    }
}
