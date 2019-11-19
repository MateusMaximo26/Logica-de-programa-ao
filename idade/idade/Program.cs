using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, menor, idade;

            Console.Write("Informe a idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade > 21)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
            Console.ReadKey();
        }
    }
}
