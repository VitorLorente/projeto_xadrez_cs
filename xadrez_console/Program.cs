﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            /*Tabuleiro tab = new Tabuleiro(8, 8);
            try {
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }*/

            PosicaoXadrez posX = new PosicaoXadrez('a', 1);
            Console.WriteLine(posX);
            Console.WriteLine(posX.toPosicao());

            Console.ReadLine();
        }
    }


}
