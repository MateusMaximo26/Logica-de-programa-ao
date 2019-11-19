using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {//vetor de numeros inteiros
            int[] vetor = new int[5];
            int i;

            //inserindo valores no vetor
            for(i = 0; i < 5; i++)
            {
                Console.Write("Digite o [{0}°] número: ", i);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            //Mostrando os valores do vetor
            Console.WriteLine("Impressão do vetor: ");
            for (i = 0; i < 5; i++)
            {
                //Os valores são referenciados na memoria Ram
                //Como sendo {0} a valor de i e {i} o valor de vetor [1]
                Console.WriteLine("[{0}°]= {1}", i, vetor[i]);
            }
            //Finaliza
            Console.ReadKey();
        }
    }
}
