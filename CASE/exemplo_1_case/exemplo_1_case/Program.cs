using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_1_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao; //variavel utilizada do menu
            Console.Write("\n Informe uma das opções: \n\n" + " A-Abrir\n P-Pesquisar\n W-Salvar\n S-Sair: \n");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case"A":
                    Console.WriteLine("Você selecionou Abrir");
                    break;

                case"P":
                    Console.WriteLine("Você selecionou Pesquisar: ");
                    break;

                case"W":
                    Console.WriteLine("Você selecionou Salvar");
                    break;

                case "S":
                    Console.WriteLine("Você selecionou Sair");
                    break;

                default:
                    Console.WriteLine("Opcão invalida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
