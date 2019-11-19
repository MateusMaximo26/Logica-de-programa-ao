using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetHo = new int[5];
            int[] vetMu = new int[5];
            int i, pMualta = 0, pMubaixa = 0, pHoalto = 0, pHobaixo = 0, maisaltoHo = 0, maisbaixoHo = 0, maisaltaMu = 0, maisbaixaMu = 0;
            double somaHo = 0, somaMu = 0, media = 0, total = 0;

            Console.Write("Inserindo alturas do vetor mulher***\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0}º valor: ", i);
                vetMu[i] = int.Parse(Console.ReadLine());
                somaMu = somaMu + vetMu[i];//somando todos elementos do vetor Mulher
                if (vetMu[i] > maisaltaMu)
                {
                    maisaltaMu = vetMu[i];
                    pMualta = i;
                }
                else
                {
                    if (vetMu[i] < maisbaixaMu)
                    {
                        maisbaixaMu = vetMu[i];
                        pMubaixa = i;
                    }
                }
            }
            Console.Write("\nposição mulher mais alta: {0}ª / com altura:{1}", pMualta, maisaltaMu);
            Console.Write("\nposição mulher mais baixa: {0}ª / com altura: {1}", pMubaixa, maisbaixaMu);
            Console.Write("\nInserindo alturas do vetor homem***\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0}º valor: ", i);
                vetHo[i] = int.Parse(Console.ReadLine());
                somaHo = somaHo + vetHo[i];//somando todos elementos do vetor Mulher
                if (vetHo[i] > maisaltoHo)
                {
                    maisaltoHo = vetHo[i];
                    pHoalto = i;
                }
                else
                {
                    if (vetHo[i] < maisbaixoHo)
                    {
                        maisbaixoHo = vetHo[i];
                        pHobaixo = i;
                    }
                }
            }
            Console.Write("\nposição homem mais alto: {0}ª / com altura:{1}", pHoalto, maisaltoHo);
            Console.Write("\nposição homem mais baixo: {0}ª / com altura: {1}", pHobaixo, maisbaixoHo);
            //média das alturas homens e mulheres
            total = somaMu + somaHo;
            media = total / 10;
            Console.Write("\nTotal das alturas de homens e mulheres: " + total);
            Console.Write("\nMédia das alturas de homens e mulheres: " + media);
            Console.ReadKey();
        }
    }
}