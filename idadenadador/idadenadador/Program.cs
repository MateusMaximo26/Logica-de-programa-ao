using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idadenadador
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, categoria;

            Console.Write("Informe a idade do nadador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 5)
            {
                Console.Write("O nadador está na idade infantil");
            }
            else
            {
                if ((idade >= 5) && (idade <= 7))
                {
                    Console.Write("O nadador está na fase infantil");
                }
                else
                {
                    if ((idade >= 8) && (idade <= 10))
                    {
                        Console.Write("O nadador está na fase juvenil");
                    }

                    else
                    {
                        if ((idade >= 11) && (idade <= 15))
                        {
                            Console.Write("O nadador está na adolescencia");
                        }
                        else
                        {
                            if ((idade >= 16))
                            {
                                Console.Write("O nadador está na fase adulto");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
