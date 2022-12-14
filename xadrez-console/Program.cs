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
                PartidadeXadrez partidadeXadrez = new PartidadeXadrez();
                while (!partidadeXadrez.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partidadeXadrez);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partidadeXadrez.ValidarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partidadeXadrez.Tab.peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partidadeXadrez.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partidadeXadrez.ValidarPosicaoDestino(origem, destino);

                        partidadeXadrez.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
                Console.Clear();
                Tela.ImprimirPartida(partidadeXadrez);
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
