using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Da_Velha.tabuleiro
{
    internal class VelhaException : Exception
    {
        public VelhaException(string msg) : base(msg)
        {
        }
    }
}
