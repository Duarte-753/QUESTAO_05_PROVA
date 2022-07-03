using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_05_PROVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nome: Julio Duarte Batista RA: 6322046

            //5 - Fazer um programa para encontrar todos os números pares entre 1 e 100.
            int i;
            for ( i = 1; i < 101; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
