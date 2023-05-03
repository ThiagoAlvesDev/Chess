using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(OTabuleiro tab, Cor cor) : base (tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
