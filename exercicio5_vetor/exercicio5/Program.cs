using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int soma = 0;
            int media = 0;
            int i;//contador de for

            //inserindo valores no vetor A
            Console.Write("Inserindo valores no vetor A***\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                A[i] = int.Parse(Console.ReadLine());

                soma = soma + A[i];
                media = soma / 10;
            }
            
            Console.Write("A média das idades é: " + media);

            //Finaliza
            Console.ReadKey();
        }
    }
}
