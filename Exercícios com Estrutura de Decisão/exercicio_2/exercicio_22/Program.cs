using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //var 
            int n1, n2;

            //inicio
            Console.Write("Informe um número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe um número: ");
            n2 = int.Parse(Console.ReadLine());

            //estrutura de decisão

            //se os numeros forem iguais, vai ser o primeiro if
            if (n1 == n2)
            {
                Console.Write("Iguais");

            }

            //senão, ele vai procurar outros resultados
            else
            {

                //se o primeiro numero foi maior que o segundo, vai ser esse o resultado
                if (n1 > n2)
                {
                    Console.Write("o primeiro numero é maior que o segundo");
                }

                //senão
                else
                {

                    //esse é o resultado
                    if (n1 < n2)
                    {
                        Console.Write("o primeiro numero é menor que o segundo");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}


