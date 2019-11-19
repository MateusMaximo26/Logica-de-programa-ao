using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lernumbfor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ler 8 numeros e verificar se é par
            int i, num;

            for(i=1; i<=20; i++)
            {
                Console.Write("\nInforme o [{0}º] numero: ", i);
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) //Se o resto da divisão for zero
                {
                    Console.Write("Numero Par: " + num);
                }
                else//Senão
                {
                    Console.Write("Numero Impar: " + num);
                }
            }
            Console.ReadKey();
     
        }
    }
}
