using System;
using System.IO;
using System.Collections.Generic;

namespace Desafio20
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivo = new Arquivo(@"C:\Users\017567631\source\repos\TreinamentoAssociates\Desafio20\minhaData.txt");
            arquivo.Converter();

            var listaExportacao = new List<IExportarDados>();
            listaExportacao.Add(new ExportarConsole());
            listaExportacao.Add(new ExportarArquivo());

            foreach (var exportacao in listaExportacao)
            {
                arquivo.ExportarDados(exportacao);
            }
        }
    }
}

