using System;

namespace Desafio22.Excecoes
{
    class CaracterInvalidoException : ApplicationException
    {
        public override string Message => "CARACTER INVÁLIDO: ";
    }
}

