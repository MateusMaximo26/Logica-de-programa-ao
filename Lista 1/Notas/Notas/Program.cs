using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {//Ler 5 notas de um aluno

            int i;//contador
            double nota = 0, somadasnotas = 0, mediadasnotas = 0;

            //laços de repetição para ler as 5 notas
            for (i = 1; i <=5; i++)
            {
                Console.Write("Informe a [{0}ª] nota: ", i);
                nota = double.Parse(Console.ReadLine());

                //soma todas as notas
                somadasnotas = somadasnotas + nota;
            }

            //calcula a media das notas
            mediadasnotas = somadasnotas / 5;
            Console.Write("\nA Soma das notas é: " + somadasnotas);
            Console.Write("\nA Média das notas é: " + mediadasnotas);

            Console.ReadKey();
        }
    }
}
