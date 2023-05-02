using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro.Enums;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } 
        public int QteMovimentos { get; protected set; }
        public OTabuleiro Tab { get; protected set; }

        public Peca ( Cor cor, OTabuleiro tab)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tab = tab;
            QteMovimentos = 0;
        }
    }
}
