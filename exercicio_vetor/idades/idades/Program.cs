using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir 5 idades

            int[] idade = new int[5];
            int i;

            //Inserindo as idade
            for (i = 0; i < 5; i++)
            {
                Console.Write("Informe a [{0}º] idade: ", i);
                idade[i] = int.Parse(Console.ReadLine());
            }

            //Mostrando as idade
            Console.WriteLine("As idades são: ");
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine("[{0}º]= {1}", i, idade[i]);
            }
            Console.ReadKey();
        }
    }
}
