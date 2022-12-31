using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    internal class PosicaoVelha
    {
        public char Coluna { get; private set; }
        public int Linha { get; set; }

        public PosicaoVelha(int linha, char coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Posicao toPosicao()
        {
            return new Posicao(3 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return $"{Linha},{Coluna}";
        }
    }
}
