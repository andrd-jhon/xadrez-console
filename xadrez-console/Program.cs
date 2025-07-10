using System;
using xadrez_console.Tabuleiro;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(3, 4);

            Console.WriteLine($"Posição: {p}");
        }
    }
}
