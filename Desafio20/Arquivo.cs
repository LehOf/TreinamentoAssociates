using System;
using System.IO;

namespace Desafio20
{
    class Arquivo
    {
        private string _caminhoDoArquivo { get; set; }

        public Arquivo(string caminho)
        {
            _caminhoDoArquivo = caminho;
        }

        public void LendoArquivo()
        {
            try
            {
                using (StreamReader sr = File.OpenText(_caminhoDoArquivo))
                {
                    while (!sr.EndOfStream)
                    {
                       var line = sr.ReadLine();

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public void RetornandoTresNovosArquivos()
        {


        }
    }
}
