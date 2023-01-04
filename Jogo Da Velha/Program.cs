using Jogo_Da_Velha.Jogo_da_Velha;
using Jogo_Da_Velha.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Jogo_Da_Velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            Tipo primeiro;
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Quem irá começar? (X/O)");
                        resposta = Console.ReadLine();
                        if (resposta != "X" && resposta != "O" )
                            throw new VelhaException("Erro, você deve escolher entre X e O!");
                    }
                    catch (VelhaException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Pressione Enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                } while (resposta != "X" && resposta != "O" );
                primeiro = (Tipo)Enum.Parse(typeof(Tipo), resposta);
                Partida partida = new Partida(primeiro);
                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);
                        Posicao destino = Tela.posição_Velha().toPosicao();
                        partida.executarMovimento(destino);
                    }
                    catch (VelhaException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Pressione Enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.Clear();
                Tela.fimDaPartida(partida);
                do
                {
                    try
                    {
                        Console.WriteLine("Gostaria de jogar outra partida?\n1 - Sim\n2 - Não");
                        resposta = Console.ReadLine();
                        if (resposta != "1" && resposta != "2")
                        {
                            throw new VelhaException("A reposta deve ser 1 ou 2");
                        }
                        partida.Reiniciar(resposta);
                        Console.Clear();
                    }
                    catch (VelhaException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Pressione Enter para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                } while (resposta != "1" && resposta != "2");
            } while (resposta != "2");
        }
    }
}
