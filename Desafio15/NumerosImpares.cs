using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio15
{
    class NumerosImpares
    {
        private int _primeiroValor { get; set; }
        private int _segundoValor { get; set; }

        public NumerosImpares(int primeiroValor, int segundoValor)
        {
            _primeiroValor = primeiroValor;
            _segundoValor = segundoValor;
        }

        public int SomaDosNumerosImpares()
        {
            var soma = 0;
            var minValor = 0;
            var maxValor = 0;

            if(_primeiroValor < _segundoValor)
            {
                minValor = _primeiroValor;
                maxValor = _segundoValor;
            }
            else
            {
                minValor = _segundoValor;
                maxValor = _primeiroValor;
            }

            for(int numeros = minValor + 1; numeros < maxValor; numeros++)
            {
                if(numeros % 2 != 0)
                {
                    soma += numeros;
                }

            }

            return soma;
        }

        public override string ToString()
        {
            return $"{SomaDosNumerosImpares()}";
        }
    }
}
