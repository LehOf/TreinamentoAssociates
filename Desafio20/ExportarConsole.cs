using System;
using System.IO;

namespace Desafio20
{
    class ExportarConsole : IExportarDados
    {
        public void Exportar(string[] datas)
        {
            var contador = 0;

            foreach (var data in datas)
            {
                Console.WriteLine(data);
            }
        }
    }
}
