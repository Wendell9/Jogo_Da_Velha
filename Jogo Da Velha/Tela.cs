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

        public static void VerificarPosicao(string entrada)
        {
            if (entrada.Length != 2)
            {
                throw new VelhaException("A coordenada deve conter uma letra(linha) e uma coluna!");
            }
            if (entrada[0] != 'a' && entrada[0] != 'b' && entrada[0] != 'c')
            {
                throw new VelhaException("O primeiro caractere da coordenada deve ser uma das letras('a', 'b' ou 'c')!");
            }
            if (entrada[1] != '1' && entrada[1] != '2' && entrada[1] != '3')
            {
                throw new VelhaException("O segundo caractere da coordenada deve ser um número de 1 a 3");
            }
        }

        public static PosicaoVelha posição_Velha()
        {
            string s = Console.ReadLine();
            VerificarPosicao(s);
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoVelha(linha, coluna);
        }

        public static void fimDaPartida(Partida partida)
        {
            if (partida.Vencedor == false)
            {
                ImprimirTela(partida.Tab);
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
