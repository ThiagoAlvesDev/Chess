using Tabuleiro;
using Xadrez; 
using Tabuleiro.Enums;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OTabuleiro tab = new OTabuleiro(8, 8);

            try
            {

                tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 1));
                tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(7, 0));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //OTabuleiro tab = new OTabuleiro(8, 8);

            //Tela.ImprimirTabuleiro(tab);

            //PosicaoXadrez pos = new PosicaoXadrez('c', 3);

            //Console.WriteLine(pos);
            //Console.WriteLine(pos.ToPosicao());
            //Console.ReadLine(); 


        }
    }
}