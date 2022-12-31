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
            Tipo primeiro;
            Console.WriteLine("Quem irá começar? (X/O)");
            primeiro = (Tipo)Enum.Parse(typeof(Tipo), Console.ReadLine());
            Partida partida = new Partida(primeiro);
            while (!partida.Terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);
                    Posicao destino = Tela.posição_Velha().toPosicao();
                    partida.colocarPeca(destino);
                }
                catch(VelhaException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Tela.fimDaPartida(partida);
            Console.ReadLine();
        }
    }
}
