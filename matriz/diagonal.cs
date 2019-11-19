using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] diagonal = new int[3];
            Console.WriteLine("\n*****Matriz1*****");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t[{0},{1}]: ", i + 1, j + 1);
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n***Matriz Soma***\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    diagonal[i, j] = 
                    Console.Write("\t[{0},{1}]: {2} \t", i + 1, j + 1, matriz1[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
