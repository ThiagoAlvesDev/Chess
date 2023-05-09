using Tabuleiro;
using Tabuleiro.Enums;

namespace Xadrez
{
    internal class PartidaDeXadrez
    {
        public OTabuleiro Tab {get; private set;}
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new OTabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            Terminada = false;
            ColocarPecas();
        }
        
        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQuantidadeMovimento();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {

            Tab.ColocarPeca(new Torre(Tab, Cor.Preto), new PosicaoXadrez('a', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('a', 1).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preto), new PosicaoXadrez('e', 8).ToPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branco), new PosicaoXadrez('e', 1).ToPosicao());
        }
    }
}
