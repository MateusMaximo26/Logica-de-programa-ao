using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_matriz___matriz
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] matrizsoma = new int[3, 3];
            Console.WriteLine("\n*****Matriz1*****");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t[{0},{1}]: ", i + 1, j + 1);
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\n*****Matriz2*****\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t[{0},{1}]: {2} + \t", i + 1, j + 1, matriz1[i, j]);
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
               
            }
            Console.WriteLine("\n***Matriz Soma***\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizsoma[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write("\t[{0},{1}]: {2} \t", i + 1, j + 1, matrizsoma[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
