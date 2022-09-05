using System;

namespace Desafio23
{
    class Caracteres
    {
        public Caracteres()
        {

        }
        public void ContarCaracterPalavra()
        {
            var contador = 0;
            var tamanhoDaPalavra = 0;
            string[] palavra;

            while (true)
            {
                Console.Write("DIGITE UMA FRASE: ");
                palavra = Console.ReadLine().Split(' ');
                tamanhoDaPalavra = palavra[contador].Length;
                for(int i=0; i<palavra.Length; i++)
                {
                    Console.Write($"{tamanhoDaPalavra = palavra[contador].Length}- ");
                    contador++;
                }

                contador++;
                Console.WriteLine("");

                if (tamanhoDaPalavra == 0)
                {
                    break;
                }
            }


        }


    }
}
