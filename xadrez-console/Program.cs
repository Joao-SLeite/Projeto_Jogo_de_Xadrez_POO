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
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidadeXadrez.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partidadeXadrez.ExecutarMovimento(origem, destino);
                }
             
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
