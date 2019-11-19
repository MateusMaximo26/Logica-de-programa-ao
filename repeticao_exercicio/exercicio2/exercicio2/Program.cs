using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {/*Elabore um programa que o usuario entre com 5 numeros inteiros quaisquer. Imprima a soma de todos os numeros digitados*/
            int num1, num2, num3, num4, num5, soma;
            string continua = "S";

            while (continua == "S")
            {
                Console.Write("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro numero: ");
                num3 = int.Parse(Console.ReadLine());

                Console.Write("Digite o quarto numero: ");
                num4 = int.Parse(Console.ReadLine());

                Console.Write("Digite o quinto numero: ");
                num5 = int.Parse(Console.ReadLine());

                soma = num1 + num2 + num3 + num4 + num5;

                Console.Write("A soma é " + soma);

                Console.Write("\nDeseja continuar? S/N\n");
                //toUpper() transforma a string em maiuscula!
                continua = Console.ReadLine().ToUpper();
                if (continua == "N")//ou seja, o usuario escolheu N
                {
                    Console.Write("Encerrando...");
                }
                Console.ReadKey();
            }
        }
    }
}
