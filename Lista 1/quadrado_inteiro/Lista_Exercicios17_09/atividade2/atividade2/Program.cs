using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int atividade, reajuste, salariomensal;
            double salario, salariofinal;

            Console.Write("Qual a sua atividade \n 1- Tecnico \n 2- Engenheiro \n 3- Demais funções \nInforme: ");
            atividade = int.Parse(Console.ReadLine());

            switch (atividade)
            {
                case 1:
                    Console.Write("Informe o salario: ");
                    salario = Double.Parse(Console.ReadLine());

                    salariofinal = salario + (salario * 0.5);

                    Console.WriteLine("Técnico teve reajuste de 50% o salario final é " + salariofinal + "R$");
                    break;
                case 2:
                    Console.Write("Informe o salario: ");
                    salario = Double.Parse(Console.ReadLine());

                    salariofinal = salario + (salario * 0.3);

                    Console.WriteLine("Engenheiro teve reajuste de 30% o salario final é " + salariofinal + "R$");
                    break;
                case 3:
                    Console.Write("Informe o salario: ");
                    salario = Double.Parse(Console.ReadLine());

                    salariofinal = salario + (salario * 0.1);

                    Console.WriteLine("Demais funções teve reajuste de 10% o salario final é " + salariofinal + "R$");
                    break;

                default :
                    Console.Write("Função invalida!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
