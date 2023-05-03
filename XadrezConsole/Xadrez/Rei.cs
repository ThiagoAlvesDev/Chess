using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(OTabuleiro tab, Cor cor) : base (tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
