using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            int signo, mes, dia;

            Console.Write("Informe o mês: ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 20)
                    {
                        Console.Write("Você é de Capricornio");
                    }
                    else
                    {
                        if (dia >=21 && dia <= 31)
                        {
                            Console.Write("Você é de Aquario");
                        }
                    }

                    break;

                case 2:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 19)
                    {
                        Console.Write("Você é de Aquario");
                    }
                    else
                    {
                        if (dia >= 20 && dia <= 31)
                        {
                            Console.Write("Você é de Peixes!");
                        }
                    }

                    break;

                case 3:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 20)
                    {
                        Console.Write("Você é de Peixes");
                    }
                    else
                    {
                        if (dia >= 21 && dia <= 31)
                        {
                            Console.Write("Você é de Aries!");
                        }
                    }

                    break;

                case 4:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 20)
                    {
                        Console.Write("Você é de Aries");
                    }
                    else
                    {
                        if (dia >= 21 && dia <= 31)
                        {
                            Console.Write("Você é de Touros!");
                        }
                    }

                    break;

                case 5:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 20)
                    {
                        Console.Write("Você é de Touros");
                    }
                    else
                    {
                        if (dia >= 21 && dia <= 31)
                        {
                            Console.Write("Você é de Gemeos!");
                        }
                    }

                    break;

                case 6:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 20)
                    {
                        Console.Write("Você é de Gemeos");
                    }
                    else
                    {
                        if (dia >= 21 && dia <= 31)
                        {
                            Console.Write("Você é de Cancer!");
                        }
                    }

                    break;

                case 7:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 21)
                    {
                        Console.Write("Você é de Cancer");
                    }
                    else
                    {
                        if (dia >= 22 && dia <= 31)
                        {
                            Console.Write("Você é de Leão!");
                        }
                    }

                    break;

                case 8:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 22)
                    {
                        Console.Write("Você é de Leão");
                    }
                    else
                    {
                        if (dia >= 23 && dia <= 31)
                        {
                            Console.Write("Você é de Virgem!");
                        }
                    }

                    break;

                case 9:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 22)
                    {
                        Console.Write("Você é de Virgem");
                    }
                    else
                    {
                        if (dia >= 23 && dia <= 31)
                        {
                            Console.Write("Você é de Libra!");
                        }
                    }

                    break;

                case 10:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 22)
                    {
                        Console.Write("Você é de Libra");
                    }
                    else
                    {
                        if (dia >= 23 && dia <= 31)
                        {
                            Console.Write("Você é de Escorpiao!");
                        }
                    }

                    break;

                case 11:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 21)
                    {
                        Console.Write("Você é de Escorpiao");
                    }
                    else
                    {
                        if (dia >= 22 && dia <= 31)
                        {
                            Console.Write("Você é de Sagitario!");
                        }
                    }

                    break;

                case 12:

                    Console.Write("Informe o dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if (dia >= 1 && dia <= 21)
                    {
                        Console.Write("Você é de Sagitario");
                    }
                    else
                    {
                        if (dia >= 22 && dia <= 31)
                        {
                            Console.Write("Você é de Capricornio!");
                        }
                    }

                    break;

                default:
                    Console.Write("Você é de dinossauros");
                    break;


            }
            Console.ReadKey();
        }
    }
}
