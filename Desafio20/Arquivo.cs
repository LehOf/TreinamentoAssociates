using System;
using System.IO;

namespace Desafio20
{
    class Arquivo
    {
        private readonly string _caminhoArquivo;
        private string[] _datas;

        public Arquivo(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        private DateTime LerArquivo()
        {
            return DateTime.Parse(File.ReadAllLines(_caminhoArquivo)[0]);
        }

        private string[] ConverterDatas(DateTime data)
        {
            return new string[]
            {
                data.ToString("MM/dd/yy"),
                data.ToString("yy/MM/dd"),
                data.ToString("dd-MM-yy")
            };
        }

        public void Converter()
        {
            var data = LerArquivo();
            _datas = ConverterDatas(data);
        }

        public void ExportarDados(IExportarDados exportarDados)
        {
            exportarDados.Exportar(_datas);
        }

    }
}
