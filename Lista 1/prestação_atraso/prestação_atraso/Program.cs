using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestação_atraso
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, v, t, tempo;

            Console.Write("Informe o valor da prestação: ");
            v = double.Parse(Console.ReadLine());

            Console.Write("Informe o tempo de atraso: ");
            tempo = double.Parse(Console.ReadLine());

            Console.Write("Informe a taxa de juros: ");
            t = double.Parse(Console.ReadLine());

            p = v + (v * (t / 100) * tempo);

            Console.Write("O valor da prestação sera de: " + p);

            Console.ReadKey();
        }
    }
}
