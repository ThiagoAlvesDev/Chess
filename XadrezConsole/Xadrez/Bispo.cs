using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(OTabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "B";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //Diagonal superior direito
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
                pos.Coluna = pos.Coluna + 1;
            }

            // Diagona Inferior direito
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
                pos.Coluna = pos.Coluna + 1;
            }

            // Diagonal Inferior esquerdo
            pos.DefinirValores(Posicao.Linha +1, Posicao.Coluna -1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.Linha = pos.Linha + 1;
                pos.Coluna = pos.Coluna - 1;
            }

            // Diagonal superior Esquerdo
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
                pos.Coluna = pos.Coluna - 1;
            }
            return mat;
        }
    }
}
