using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vendido, arrecadado, preco;
            double quantidade, tipo;

            Console.Write("Quantidade de picole: ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("Tipo do picole: ");
            tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    tipo = (quantidade * 0.50);
            }
        }
    }
}
