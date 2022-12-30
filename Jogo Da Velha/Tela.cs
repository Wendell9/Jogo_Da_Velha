using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Jogo_Da_Velha
{
    internal static class Tela
    {
        public static void ImprimirTela(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas ; i++)
            {
                Console.Write($"{3 - i} ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Pecas[i,j] ==null)
                    {
                        Console.Write("[-] ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a   b   c");
        }
    }
}
