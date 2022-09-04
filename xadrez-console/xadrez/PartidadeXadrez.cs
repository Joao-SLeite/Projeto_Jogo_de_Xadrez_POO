using System;
using tabuleiro;

namespace xadrez
{
    class PartidadeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int _turno;
        private Cor _jogadorAtual;
        public bool Terminada { get; private set; }
        public PartidadeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.Branca;
            Terminada = false;
            _colocarPecas();
        }
        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tab.RetirarPeca(origem);
            peca.IncrementarQteMovimentos();
            Peca pecaCap = Tab.RetirarPeca(destino);
            Tab.colocarPeca(peca, destino);
        }
        private void _colocarPecas()
        {
            Tab.colocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 2).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.colocarPeca(new Rei(Cor.Branca, Tab), new PosicaoXadrez('d', 1).ToPosicao());

            Tab.colocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 7).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('d', 7).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 7).ToPosicao());
            Tab.colocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 8).ToPosicao());
            Tab.colocarPeca(new Rei(Cor.Preta, Tab), new PosicaoXadrez('d', 8).ToPosicao());
        }
    }
}
