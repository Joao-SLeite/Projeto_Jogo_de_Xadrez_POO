using tabuleiro;
using System;
using xadrez;
using System.Collections.Generic;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirPartida(PartidadeXadrez partidadeXadrez)
        {
            Tela.ImprimirTabuleiro(partidadeXadrez.Tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partidadeXadrez);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partidadeXadrez.Turno);
            Console.WriteLine("Aguardando jogada da peça: " + partidadeXadrez.JogadorAtual);
        }
        public static void ImprimirPecasCapturadas(PartidadeXadrez partidadeXadrez)
        {
            Console.WriteLine("Peças Capituradas: ");
            Console.Write("Peças Brancas: ");
            ImprimirConjunto(partidadeXadrez.PecasCapituradas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Peças Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partidadeXadrez.PecasCapituradas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }
        public static void ImprimirConjunto(HashSet<Peca> pecas)
        {
            Console.Write("[");
            foreach(Peca peca in pecas)
            {
                Console.Write(peca + " ");
            }
            Console.Write("]");
        }
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    ImprimirPeca(tabuleiro.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tabuleiro.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }

        }
        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string pos = Console.ReadLine();
            char coluna = pos[0];
            int linha = int.Parse(pos[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
