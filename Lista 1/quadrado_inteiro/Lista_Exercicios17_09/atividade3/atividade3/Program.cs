using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagamento;
            double valor, preco;

            Console.Write("Informe o valor da compra: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Qual a forma de pagamento? \n Tipo(1) a vista com 50% de desconto \n Tipo(2) no cheque com 40% de desconto \n Tipo(3) no Crédito com 30% de desconto ");
            pagamento = int.Parse(Console.ReadLine());

            switch (pagamento)
            {
                case 1:
                    preco = valor - ((50.0 / 100.0) * valor);

                    Console.Write("O valor é " + preco);
                    break;

                case 2:
                    preco = valor - ((40.0 / 100.0) * valor);

                    Console.Write("O valor é " + preco);
                    break;

                case 3:
                    preco = valor - ((30.0 / 100.0) * valor);

                    Console.Write("O valor é " + preco);
                    break;

                default:
                    Console.Write("O valor é " + valor);
                    break;

            }

            Console.ReadKey();
        }
    }
}
