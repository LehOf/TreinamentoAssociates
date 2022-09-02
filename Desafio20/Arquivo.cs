using System;
using System.IO;

namespace Desafio20
{
    class Arquivo : IImpressaoInterface
    {
        private string _caminhoDoArquivo { get; set; }

        public Arquivo(string caminho)
        {
            _caminhoDoArquivo = caminho;
        }

        public string LendoArquivo()
        {
            using (StreamReader sr = File.OpenText(_caminhoDoArquivo))
            {
                while (!sr.EndOfStream)
                {
                    return sr.ReadLine();
                }
            }

            return "";
        }

        public void ConverterDatas()
        {
            var data = DateTime.Parse(LendoArquivo());

            var Date = data.Date.ToString("MM/dd/yyyy");
            var DateFormaDois = data.ToString("yyyy/MM/dd");
            var DateFormatoTres = data.ToString("dd-MM-yyyy");

            Console.WriteLine($"{Date} \n{DateFormaDois} \n{DateFormatoTres}");
        }

        public void ImprimirNoConsole()
        {
            ConverterDatas();
        }

        public void ImprimirNoArquivo()
        {

        }
    }
}
