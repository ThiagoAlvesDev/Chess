using Tabuleiro;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OTabuleiro tab = new OTabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);

          
        }
    }
}