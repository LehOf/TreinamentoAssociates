using System;

namespace Desafio19
{
    class EscolhaException : ApplicationException
    {
        public override string Message => "SOMA EXCEDEU O NÚMERO DE FAIXAS EXISTENTES: ";
    }
}
