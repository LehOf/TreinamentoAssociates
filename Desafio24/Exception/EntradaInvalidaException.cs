using System;

namespace Desafio24.Exception
{
    class EntradaInvalidaException : ApplicationException
    {
        public override string Message => "ENTRADA FORA DOS LIMITES: REINICIE O PROGRAMA E INFORME UMA ENTRADA VÁLIDA: ";
    }
}
