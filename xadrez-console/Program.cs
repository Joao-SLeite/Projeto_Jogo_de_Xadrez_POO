using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.colocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(1, 3));
                tabuleiro.colocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 1));

                tabuleiro.colocarPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(3, 5));
                Tela.ImprimirTabuleiro(tabuleiro);

                /*
                PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);
                Console.WriteLine(posicaoXadrez);
                Console.WriteLine(posicaoXadrez.ToPosicao());
                */
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Um erro ocurreu");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
