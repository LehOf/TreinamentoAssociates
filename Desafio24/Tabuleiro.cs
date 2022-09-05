using System;
using Desafio24.Exception;

namespace Desafio24
{
    public class Tabuleiro
    {
        public string TratarEntrada(int numeroDaMatriz)
        {
            var resultado = "";

            if (numeroDaMatriz < 2 || (numeroDaMatriz > 100))
            {
                var error = new EntradaInvalidaException();
                resultado = (error.Message);
            }
            else
            {
                resultado = (CalculandoBrancasPretas(numeroDaMatriz));
            }
            return resultado;
        }

        public string CalculandoBrancasPretas(int numeroDaMatriz)
        {
            var brancas = 0;
            var pretas = 0;
            var ultimaCorEscolhida = "preta";

            int[,] dimensao = new int[numeroDaMatriz, numeroDaMatriz];

            for (int i = 0; i < numeroDaMatriz; i++)
            {
                for (int j = 0; j < numeroDaMatriz; j++)
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

