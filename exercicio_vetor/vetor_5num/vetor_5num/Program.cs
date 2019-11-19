using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_5num
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um vetor que leia 5 numeros e imprima o vetor invertido
            int[] vetor = new int[5];
            int[] invertido = new int[5];
            int i;

          
                Console.Writeline("\n****vetor normal****");
             

            for (i = 0;i < vetor.Length; i++)
            {
                Console.Write("[{0}º] = ", i);
                vetor[i] = int.Parse(Console.ReadLine());

            }

            for (i = 0; i < vetor.Length; i++)
            {
                invertido[i] = vetor.Length - 1 - i];
            }
            Console.WriteLine("\n****vetor normal****");
            for (i = 0; i < invertido.Length; i++)
            {
                Console.WriteLine("[{0}]º = {1}", i, invertido[i]);
            }

            Console.ReadKey();
        }
    }
}
