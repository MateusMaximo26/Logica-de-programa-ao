using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posicao6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int[] posicao = new int[6];
            int i = 0, idade = 0;

            for(i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe a [{0}]º idade do atleta: ");
                idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A 6º idade é: ");

            for (i = 0; i < vetor.Length; i++)
            {
                posicao[i] = vetor[vetor.Length - 4 - i];
            }
            Console.WriteLine("[{0}]º = {1}", i, posicao[i]);
            Console.ReadKey();
        }
    }
}
