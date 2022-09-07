using System;
using System.IO;

namespace Desafio25.Exceptions
{
    class EntradaInvalidaException : ApplicationException
    {
        public override string Message => "ENTRADA FORA DOS LIMITES: REINICIE O PROGRAMA E INFORME UMA ENTRADA VÁLIDA: ";
    }
}

