using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_com_Estrutura_de_Decisão1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            int idade;

            //inicio
            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            //estrutura de decisão
            if(idade>=21)
            {
                Console.Write("Maior de idade");
            }
            else
            {
                Console.Write("Menor de idade");
            }
            Console.ReadKey();
                 
        }
    }
}
