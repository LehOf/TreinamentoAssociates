using System;

namespace Desafio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UMA FRASE: ");
            var frases = Console.ReadLine().Split(' ');


            var caracter = new Caracteres(frases);

            caracter.ContarCaracterPalavra();
            caracter.MaiorPalavra();
        }
    }
}


