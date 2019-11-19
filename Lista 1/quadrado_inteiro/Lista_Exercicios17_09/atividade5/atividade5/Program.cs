using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double peso, engorda15, emagrece20;

            Console.Write("Informe o peso: ");
            peso = Double.Parse(Console.ReadLine());

            Console.Write("Escolha opção \n 1- engordar 15% \n 2- emagrece 20%");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    engorda15 = peso + ((15.0 / 100.0) * peso);

                    Console.Write("O peso é " + engorda15);
                break;

                case 2:
                    emagrece20 = peso - ((20.0 / 100.0) * peso);

                    Console.Write("O peso é" + emagrece20);
                    break;
            }

            Console.ReadKey();
        }
    }
}
