using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_2_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;//variavel usada no menu
            Console.Write("\nInforme uma das opções: \n" + " 1-Adição:\n 2-Subtração:\n 3-Multiplicação:\n 4-Divisão: \n");
            opcao = int.Parse(Console.ReadLine());

            double n1, n2, resultado;

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o primeiro valor: ");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o segundo valor: ");
                    n2 = double.Parse(Console.ReadLine());

                    resultado = n1 + n2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 2:
                    Console.WriteLine("Informe o primeiro valor: ");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o segundo valor: ");
                    n2 = double.Parse(Console.ReadLine());

                    resultado = n1 - n2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 3:
                    Console.WriteLine("Informe o primeiro valor: ");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o segundo valor: ");
                    n2 = double.Parse(Console.ReadLine());

                    resultado = n1 * n2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;


                case 4:
                    Console.WriteLine("Informe o primeiro valor: ");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o segundo valor: ");
                    n2 = double.Parse(Console.ReadLine());

                   if (n2 == 0)//nao existe divisão por 0
                   {
                        Console.WriteLine("Não existe divisão por zero!");
                   }
                   else
                   {
                        resultado = n1 / n2;
                        Console.WriteLine("Resultado: " + resultado);
                   }
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
