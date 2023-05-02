using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class OTabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        
        private Peca[,] Pecas;

        public OTabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
    }
}
