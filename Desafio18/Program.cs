using System;

namespace Desafio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE O NÚMERO DE JOGADAS: ");
            var jogadas = int.Parse(Console.ReadLine());

            Jogo jogo = new Jogo(jogadas);

            jogo.RegraDoJogo();
        }
    }
}
