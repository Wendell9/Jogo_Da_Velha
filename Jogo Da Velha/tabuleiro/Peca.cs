using System;
using System.Collections.Generic;
using System.Linq;
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

        public Peca(Tipo tipo, Tabuleiro tab)
        {
            Pos = null;
            Tipo = tipo;
            this.tab = tab;
        }
    }
}
