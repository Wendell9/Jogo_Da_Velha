using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Jogo_Da_Velha.tabuleiro
{
    internal class Peca
    {
        public Posicao Pos { get; set; }
        public Tipo Tipo { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca()
        {
        }

        public Peca(Posicao pos,Tipo tipo, Tabuleiro tab)
        {
            Pos = pos;
            Tipo = tipo;
            this.tab = tab;
        }

        public override string ToString()
        {
            if (Tipo==Tipo.X)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }
    }
}
