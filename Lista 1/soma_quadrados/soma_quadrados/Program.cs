using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_quadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, soma;

            Console.Write("Informe o primeiro número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Informe o terçeiro número: ");
            c = int.Parse(Console.ReadLine());

            soma = (a * a) + (b * b) + (c * c);

            Console.Write("O valor da soma dos números é: " + soma);

            Console.ReadKey();
        
        }
    }
}
