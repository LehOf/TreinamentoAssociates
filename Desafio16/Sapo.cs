using System;

namespace Desafio16
{
    class Sapo
    {
        private int _alturaSapo { get; set; }
        private int _quantidadesCanos { get; set; }
        private int[] _alturaCanos { get; set; }

        public Sapo(int altura, int quantidadesCanos)
        {
            _alturaSapo = altura;
            _quantidadesCanos = quantidadesCanos;
        }

        public string Calcular()
        {
            int valor = 0, subtracao = 0;

            Console.Write("Digite as alturas dos canos: ");
            string[] EntradaAlturaDosCanos = Console.ReadLine().Split(' ');

            _alturaCanos = new int[_quantidadesCanos];

            for (int i = 0; i < _quantidadesCanos; i++)
            {
                _alturaCanos[i] = int.Parse(EntradaAlturaDosCanos[i]);
            }

            for (int i = 1; i < _quantidadesCanos; i++)
            {
                if (_alturaCanos[i] > _alturaCanos[i - 1])
                {

                    subtracao = (_alturaCanos[i] - _alturaCanos[i - 1]);
                }
                else
                {
                    subtracao = (_alturaCanos[i - 1] - _alturaCanos[i]);
                }
            }

            if (subtracao <= _alturaSapo)
            {
                valor++;
            }
            return (valor == _alturaSapo - 1) ? "GAME OVER" : "YOU WIN";
        }
    }
}