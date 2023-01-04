using Jogo_Da_Velha.tabuleiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Jogo_Da_Velha.Jogo_da_Velha
{
    internal class Partida
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno;
        public Tipo JogadorAtual { get; set; }
        public bool Terminada { get; private set; }
        public bool Vencedor { get; private set; }

        public Partida()
        {
        }

        public Partida(Tipo jogadorAtual)
        {
            Tab = new Tabuleiro(3, 3);
            Turno = 1;
            JogadorAtual = jogadorAtual;
            Terminada = false;
            Vencedor = false;
        }

        public void executarMovimento(Posicao destino)
        {
            colocarPeca(destino);
            verificarVitoria();
            if (!Terminada)
            {
                mudaJogador();
                Turno++;
            }
        }

        public void colocarPeca(Posicao destino)
        {
            verificarPeca(destino);
            if (JogadorAtual == Tipo.X)
            {
                Peca p = new Peca(destino, Tipo.X, Tab);
                Tab.Pecas[destino.Linha, destino.Coluna] = p;
            }
            else
            {
                Peca p = new Peca(destino, Tipo.O, Tab);
                Tab.Pecas[destino.Linha, destino.Coluna] = p;
            }
        }

        public bool verificarPeca(Posicao destino)
        {
            if (Tab.Pecas[destino.Linha, destino.Coluna] != null)
            {
                throw new VelhaException("Já tem uma peça ocupando esse espaço!");
            }
            return true;
        }

        public void mudaJogador()
        {
            if (JogadorAtual == Tipo.X)
            {
                JogadorAtual = Tipo.O;
            }
            else
            {
                JogadorAtual = Tipo.X;
            }
        }

        public void Reiniciar(string resposta)
        {
            if (resposta=="1")
            {
                Terminada = false;
            }
        }

        public void verificarVitoria()
        {
            if (Tab.Pecas[0, 0] != null && Tab.Pecas[0, 1] != null && Tab.Pecas[0, 2] != null && Tab.Pecas[0, 0].Tipo == Tab.Pecas[0, 1].Tipo && Tab.Pecas[0, 2].Tipo == Tab.Pecas[0, 1].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if (Tab.Pecas[1, 0] != null && Tab.Pecas[1, 1] != null && Tab.Pecas[1, 2] != null && Tab.Pecas[1, 0].Tipo == Tab.Pecas[1, 1].Tipo && Tab.Pecas[1, 2].Tipo == Tab.Pecas[1, 0].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if (Tab.Pecas[2, 0] != null && Tab.Pecas[2, 1] != null && Tab.Pecas[2, 2] != null && Tab.Pecas[2, 0].Tipo == Tab.Pecas[2, 1].Tipo && Tab.Pecas[2, 2].Tipo == Tab.Pecas[2, 0].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if (Tab.Pecas[0, 0] != null && Tab.Pecas[1, 0] != null && Tab.Pecas[2, 0] != null && Tab.Pecas[0, 0].Tipo == Tab.Pecas[1, 0].Tipo && Tab.Pecas[2, 0].Tipo == Tab.Pecas[0, 0].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if (Tab.Pecas[0, 1] != null && Tab.Pecas[1, 1] != null && Tab.Pecas[2, 1] != null && Tab.Pecas[0, 1].Tipo == Tab.Pecas[1, 1].Tipo && Tab.Pecas[2, 1].Tipo == Tab.Pecas[0, 1].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if (Tab.Pecas[0, 2] != null && Tab.Pecas[1, 2] != null && Tab.Pecas[2, 2] != null && Tab.Pecas[0, 2].Tipo == Tab.Pecas[1, 2].Tipo && Tab.Pecas[2, 2].Tipo == Tab.Pecas[0, 2].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if (Tab.Pecas[0, 0] != null && Tab.Pecas[1, 1] != null && Tab.Pecas[2, 2] != null && Tab.Pecas[0, 0].Tipo == Tab.Pecas[1, 1].Tipo && Tab.Pecas[2, 2].Tipo == Tab.Pecas[0, 0].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if (Tab.Pecas[2, 0] != null && Tab.Pecas[1, 1] != null && Tab.Pecas[0, 2] != null && Tab.Pecas[2, 0].Tipo == Tab.Pecas[1, 1].Tipo && Tab.Pecas[1, 1].Tipo == Tab.Pecas[0, 2].Tipo)
            {
                    Terminada = true;
                Vencedor = true;
            }
            else if(Turno==9 && Vencedor == false)
            {
                Terminada = true;
            }
        }
    }
}
