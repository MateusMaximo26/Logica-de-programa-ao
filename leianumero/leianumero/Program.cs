using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leianumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("Informe o numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O numero " + numero1 + " é maior que " + numero2);
            }
            else
            {
                if (numero1 < numero2)
                {
                    Console.WriteLine("O numero " + numero1 + " é menor que " + numero2);
                }
                else
                {
                    if (numero1 == numero2)
                    {
                        Console.WriteLine("As idades são iguais");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
