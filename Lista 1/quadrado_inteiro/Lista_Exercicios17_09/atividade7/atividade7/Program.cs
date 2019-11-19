using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double precounit, valorfinal, quant;

            Console.Write("Informe o código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade do produto: ");
            quant = double.Parse(Console.ReadLine());

            valorfinal = codigo * quant;

            switch (codigo)
            {
                case 100:
                    valorfinal = (quant * 10.70);

                    Console.Write("O valor é " + valorfinal);
                    break;

                case 101:
                    valorfinal = (quant * 21.30);
                    Console.Write("O valor é " + valorfinal);
                    break;

                case 102:
                    valorfinal = (quant * 22.60);
                    Console.Write("O valor é " + valorfinal);
                    break;

                case 103:
                    valorfinal = (quant * 12.40);
                    Console.Write("O valor é " + valorfinal);
                    break;

                case 104:
                    valorfinal = (quant * 12.50);
                    Console.Write("O valor é " + valorfinal);
                    break;

                case 105:
                    valorfinal = (quant * 3.00);
                    Console.Write("O valor é " + valorfinal);
                    break;


            }

            Console.ReadKey();
        }
    }
}
