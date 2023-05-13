using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro.Enums;

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } 
        public int QteMovimentos { get; protected set; }
        public OTabuleiro Tab { get; protected set; }

        public Peca ( OTabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public void IncrementarQuantidadeMovimento()
        {
            QteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
