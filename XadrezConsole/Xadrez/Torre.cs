using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(OTabuleiro tab, Cor cor) : base (cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
