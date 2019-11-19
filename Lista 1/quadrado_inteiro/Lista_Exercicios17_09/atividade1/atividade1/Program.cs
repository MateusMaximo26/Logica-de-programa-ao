using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargo, codigo;

            Console.Write("Informe o codigo: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.Write("Programador");
                    break;

                case 2:
                    Console.Write("Analista de sistema");
                    break;
                case 3:
                    Console.Write("Programador FrontEnd");
                    break;
                case 4:
                    Console.Write("Programador FullStack");
                    break;
                case 5:
                    Console.Write("Digitador");
                    break;
                default :
                    Console.Write("Código Invalida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
