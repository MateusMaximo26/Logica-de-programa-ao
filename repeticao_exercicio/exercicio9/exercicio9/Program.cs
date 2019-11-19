using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0, maior = 0, menor = 0;
            do
            {
                Console.WriteLine("Informe um número: ");
                num0 = int.Parse(Console.ReadLine());
                if (num0 > maior)
                {
                    maior = num0;
                }
                else
                {
                    if (num0 < menor)
                    {
                        menor = num0;
                    }
                }

            } while (num0 > 0);
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
            Console.ReadKey();
        }
    }
}
