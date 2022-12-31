using Jogo_Da_Velha.Jogo_da_Velha;
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
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write($"{3 - i} ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Pecas[i, j] == null)
                    {
                        Console.Write("[-] ");
                    }
                    else
                    {
                        Console.Write($"[{tab.Pecas[i, j]}] ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a   b   c");
        }

        public static void imprimirPartida(Partida partida)
        {
            ImprimirTela(partida.Tab);
            Console.WriteLine();
            Console.WriteLine($"Turno: {partida.Turno}");
            Console.WriteLine($"Jogador atual: {partida.JogadorAtual}");
            Console.Write("Onde deseja colocar? ");
        }

        public static PosicaoVelha posição_Velha()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoVelha(linha, coluna);
        }

        public static void fimDaPartida(Partida partida)
        {
            if (partida.Vencedor == false)
            {
                Console.WriteLine("Empate. Deu velha!");
            }
            else
            {
                imprimirVencedor(partida);
            }
        }

        public static void imprimirVencedor(Partida partida)
        {
            if (partida.Terminada)
            {
                ImprimirTela(partida.Tab);
                Console.WriteLine("Partida encerrada");
                Console.WriteLine($"Vencedor: {partida.JogadorAtual}");
            }
        }
    }
}
