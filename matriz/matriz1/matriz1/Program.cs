using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[{0},{1}]: ", i + 1, j + 1);
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\n***Matriz 3 x 3***\n");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("\t[{0},{1}]: {2} \t", i + 1, j + 1, matriz1[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
