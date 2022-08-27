﻿using System;
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
                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine("Um erro ocurreu");
                Console.WriteLine(e.Message);
            }
 
            Console.ReadLine();
        }
    }
}
