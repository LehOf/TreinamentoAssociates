using System;

namespace Desafio23
{
    class Caracteres
    {
        private string[] _frases { get; set; }
        private int _maior { get; set; }
        private int _caracter { get; set; }
        private string _palavra { get; set; }

        public Caracteres()
        {

        }


        public void ContarCaracterPalavra()
        {

            do
            {
                Console.WriteLine("");
                Console.WriteLine("DIGITE UMA FRASE: ");
                _frases = Console.ReadLine().Split(' ');

                if (_frases[0] != "0")
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

                    for (int i = 0; i < _frases.Length; i++)
                    {
                        _caracter = _frases[i].Length;

                        if (_caracter < _maior)
                        {
                            _maior = _maior;
                            _palavra = _palavra;
                        }
                        else if (_caracter > _maior)
                        {
                            _maior = _caracter;
                            _palavra = _frases[i];
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"The biggest word: {_palavra}");
                }
            } while (_frases[0] != "0");
        }
    }
}
