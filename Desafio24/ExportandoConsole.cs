using System;
using Desafio24.Interface;

namespace Desafio24
{
    class ExportandoConsole : IExportandoDados
    {
        public void Exportando(Tabuleiro tabuleiro)
        {
            Console.WriteLine(tabuleiro.TratarEntrada());
        }
    }
}
