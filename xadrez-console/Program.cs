using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            tabuleiro.colocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
            tabuleiro.colocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(1, 3));
            tabuleiro.colocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(2, 4));
            Tela.ImprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}
