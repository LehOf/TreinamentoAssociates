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
            var valor = "";
            do
            {
                foreach (var frase in _frases)
                {
                    if (frase.Length > 0)
                    {
                        _maior = frase.Length;
                        _palavra = frase;
                    }
                    valor += $"{frase.Length}-";
                }
                Console.WriteLine(valor = valor.Remove(valor.LastIndexOf("-"), 1));

                Console.WriteLine("\nDIGITE UMA FRASE: ");
                _frases = Console.ReadLine().Split(' ');
                valor = "";

            } while (_frases[0] != "0");
        }

        public void MaiorPalavra()
        {
            for (int i = 0; i < _frases.Length; i++)
            {
                if (_frases[0] != "0")
                {
                    var caracter = _frases[i].Length;

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

