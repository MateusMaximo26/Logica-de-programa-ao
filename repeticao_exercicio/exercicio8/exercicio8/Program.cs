using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, soma = 0, somaim = 0, media = 0 , num0;
            string continua = "S";

            while (continua == "S")
            {

                for (i = 1; i <=10; i++)
                {
                    Console.Write("Informe o [{0}°]\n", i);
                    num0 = int.Parse(Console.ReadLine());

                    if (num0 % 2 == 0)
                    {
                        soma = num0 + soma;
                        media = soma / 20;
                    }
                    else
                    {
                        somaim = num0 + soma;
                    }

                }

                Console.WriteLine("\nA soma dos pares é: " + soma + " e a média é " + media);
                Console.WriteLine("\nA soma dos impares é: " + somaim);

                Console.Write("\nDeseja continuar? S/N");
                continua = Console.ReadLine();
                if (continua == "N")
                {
                    Console.Write("Encerrando...");
                }
                Console.ReadKey();
            }
        }
    }
}
