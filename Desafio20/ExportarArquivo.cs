using System;
using System.IO;

namespace Desafio20
{
    class ExportarArquivo : IExportarDados
    {
        public void Exportar(string[] datas)
        {
            var contador = 0;

            foreach (var data in datas)
            {
                contador++;

                using (StreamWriter sw = File.AppendText($@"C:\Users\017567631\source\repos\TreinamentoAssociates\Desafio20\Arquivo_{ contador}.txt"))
                {
                    sw.Write(data);
                }
            }
        }
    }
}
