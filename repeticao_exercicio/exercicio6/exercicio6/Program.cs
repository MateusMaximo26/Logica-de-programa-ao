using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, i=1, soma=0;

            Console.Write("Informe o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            for (i = num1; i<=num2; i++)
            {
                Console.WriteLine("Os numeros de " + num1 + " até " + num2 + " são: " + i);
                soma = i + soma;
            }
            Console.WriteLine("A soma de todos os numero de " + num1 + " até " + num2 + " são: " + soma);
            Console.ReadKey();
        }
    }
}
