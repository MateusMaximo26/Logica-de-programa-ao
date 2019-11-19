using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sconta, vdebito, vcredito, sneg, spos, satual;

            Console.Write("Informe o saldo em conta:");
            sconta = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do débito:");
            vdebito = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do Crédito:");
            vcredito = int.Parse(Console.ReadLine());

            //decisão

            satual = sconta - vdebito + vcredito;

            if (satual >= 0)
            {
                Console.Write("Saldo positivo: " + satual);

            }
            else
            {
                Console.Write("Saldo negativo: " + satual);

            }

            Console.ReadKey();
        }
    }
}
