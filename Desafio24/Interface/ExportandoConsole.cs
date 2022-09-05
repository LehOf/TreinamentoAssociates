using System;
using Desafio24.Interface;

namespace Desafio24
{
    class ExportandoConsole : IExportandoDados
    {
        public string Exportando(Tabuleiro tabuleiro, int numeroDimensao)
        {
           return (tabuleiro.TratarEntrada(numeroDimensao));
        }
    }
}
