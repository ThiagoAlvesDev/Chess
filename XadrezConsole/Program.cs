using Tabuleiro;
using Xadrez;
using Tabuleiro.Enums;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {

                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }


            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //OTabuleiro tab = new OTabuleiro(8, 8);

            //Tela.ImprimirTabuleiro(tab);

            //PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            //Console.WriteLine(pos);
            //Console.WriteLine(pos.ToPosicao());
            //Console.ReadLine();


        }
    }
}