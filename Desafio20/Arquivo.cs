using System;
using System.IO;

namespace Desafio20
{
    class Arquivo
    {
        private readonly string _caminhoArquivo;
        private string[] _datas { get; set; }

        public Arquivo(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        public DateTime LendoArquivo()
        {
            return DateTime.Parse(File.ReadAllLines(_caminhoArquivo)[0]);
        }
        public string[] ConversaoDatas(DateTime data)
        {
            return new string[]
            {
                data.ToString("MM/dd/yy"),
                data.ToString("yy/MM/dd"),
                data.ToString("dd-MM-yy")
            };
        }
        public void GerarArquivos(string[] datas)
        {
            var contador = 0;

            foreach(var data in datas)
            {
                contador++;

                using (var rw = File.AppendText($"Aquivo_{contador}.txt"))
                {
                    rw.Write(data);
                }
            }
        }

        public void GerarConsole(string[] datas)
        {
            foreach(var data in datas)
            {
                Console.WriteLine(data);
            }
        }
    }
}