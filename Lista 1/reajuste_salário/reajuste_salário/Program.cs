using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste_salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double sm, pr, ns;

            Console.Write("Informe o valor do salário: ");
            sm = double.Parse(Console.ReadLine());

            Console.Write("Informe a taxa de reajuste: ");
            pr = double.Parse(Console.ReadLine());


            ns = (sm + (sm * (pr / 100)));

            Console.Write("O novo salário é de: " + ns);

            Console.ReadKey();

        }
    }
}
