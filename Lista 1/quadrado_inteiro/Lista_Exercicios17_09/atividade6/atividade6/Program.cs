using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo, debito, saldoatual, credito;

            Console.Write("Informe o valor do saldo: ");
            saldo = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do debito: ");
            debito = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do credito: ");
            credito = int.Parse(Console.ReadLine());

            saldoatual = saldo - debito + credito;

            if (saldoatual <= 0)
            {
                Console.Write("O saldo é negativo, o valor é " + saldoatual);
            }
            else
            {
                Console.Write("O saldo é positivo, o valor é " + saldoatual);
            }

            Console.ReadKey();
        }
    }
}
