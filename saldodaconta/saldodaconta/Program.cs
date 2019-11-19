using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saldodaconta
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo, debito, credito, saldoatual;

            Console.Write("Escreva o saldo da conta: ");
            saldo = int.Parse(Console.ReadLine());

            Console.Write("Escreva o debito: ");
            debito = int.Parse(Console.ReadLine());

            Console.Write("Escreva o credito: ");
            credito = int.Parse(Console.ReadLine());

            saldoatual = saldo - debito + credito;

            if (saldoatual >= 0)
            {
                Console.Write("Saldo positivo");
            }
            else
            {
                Console.Write("Saldo negativo");
            }
            Console.ReadKey();
        }
    }
}
