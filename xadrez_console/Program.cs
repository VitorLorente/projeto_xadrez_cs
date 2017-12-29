using System;
using Tabuleiro;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            Posicao P;

            P = new Posicao(2, 3);

            Console.WriteLine(P);
            Console.ReadLine();
        }
    }
}
