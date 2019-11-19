using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {//inicio

            //declaração de variavéis
            int n1, n2, soma;

            //entradas
            Console.Write("Informe o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            //processamento
            soma = n1 + n2;

            //saida
            Console.Write("O resultado da soma é: " + soma);

            Console.ReadKey();
        }//fim
    }
}
