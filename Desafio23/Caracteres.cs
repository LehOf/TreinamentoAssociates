using System;

namespace Desafio23
{
    class Caracteres
    {
        private string[] _frases { get; set; }
        private int _maior { get; set; }
        private string _palavra { get; set; }

        public Caracteres(string[] frases)
        {
            _frases = frases;
        }

        public void ContarCaracterPalavra()
        {
            do
            {
                foreach (var frase in _frases)
                {
                    if (frase.Length > 0)
                    {
                        _maior = frase.Length;
                        _palavra = frase;
                    }
                    Console.Write($"{frase.Length}-");
                }

                Console.WriteLine("\n\nDIGITE UMA FRASE: ");
                _frases = Console.ReadLine().Split(' ');

            } while (_frases[0] != "0");
        }

        public void MaiorPalavra()
        {
            var caracter = 0;

            for (int i = 0; i < _frases.Length; i++)
            {
                if (_frases[0] != "0")
                {
                    caracter = _frases[i].Length;

                    if (caracter < _maior)
                    {
                        _maior = _maior;
                        _palavra = _palavra;
                    }
                    else if (caracter > _maior)
                    {
                        _maior = caracter;
                        _palavra = _frases[i];
                    }
                }
                else
                {
                    Console.WriteLine($"The biggest word: {_palavra}");
                }
            }
        }
    }
}
