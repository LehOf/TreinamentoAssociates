using System;
using Desafio24.Exception;

namespace Desafio24
{
    public class Tabuleiro
    {
        private int _numeroMatriz { get; set; }

        public Tabuleiro(int numeroMatriz)
        {
            _numeroMatriz = numeroMatriz;
        }

        public string TratarEntrada()
        {
            var resultado = "";

            if (_numeroMatriz < 2 || (_numeroMatriz > 100))
            {
                var error = new EntradaInvalidaException();
                resultado = (error.Message);
            }
            else
            {
                resultado = (CalcularBrancasPretas());
            }
            return resultado;
        }

        public string CalcularBrancasPretas()
        {
            var brancas = 0;
            var pretas = 0;
            var ultimaCorEscolhida = "preta";

            int[,] dimensao = new int[_numeroMatriz, _numeroMatriz];

            for (int i = 0; i < _numeroMatriz; i++)
            {
                for (int j = 0; j < _numeroMatriz; j++)
                {
                    if (ultimaCorEscolhida != "branca")
                    {
                        dimensao[i, j] = brancas++;
                        ultimaCorEscolhida = "branca";
                    }
                    else if (ultimaCorEscolhida == "branca")
                    {
                        dimensao[i, j] = pretas++;
                        ultimaCorEscolhida = "preta";
                    }

                }
            }
            return (($"{brancas} casas brancas e {pretas} casas pretas"));
        }
    }
}

