using System;
using System.IO;

namespace Desafio20
{
    class Arquivo
    {
        public string FormatoDeDataUm { get; set; }
        public string FormatoDeDataDois { get; set; }
        public string FormatoDeDataTres { get; set; }


        public void LendoArquivo(string caminho)
        {
            var fluxoDeArquivo = new FileStream(caminho, FileMode.Open);
            var leitorDeFluxo = new StreamReader(fluxoDeArquivo);
            var Linha = leitorDeFluxo.ReadLine();
            var dataOriginal = DateTime.Parse(Linha);

            FormatoDeDataUm = dataOriginal.ToString("MM/dd/yy");
            FormatoDeDataDois = dataOriginal.ToString("yy/MM/dd");
            FormatoDeDataTres = dataOriginal.ToString("dd-MM-yy");
        }
        public void CriandoNovosArquivos()
        {
            var segundoCaminho = @"C:\Users\017567631\source\repos\TreinamentoAssociates\Desafio20\CaminhoDeOrigem2.txt";
            var terceiroCaminho = @"C:\Users\017567631\source\repos\TreinamentoAssociates\Desafio20\CaminhoDeOrigem3.txt";
            var quartoCaminho = @"C:\Users\017567631\source\repos\TreinamentoAssociates\Desafio20\CaminhoDeOrigem4.txt";


            var arquivoUm = new StreamWriter(segundoCaminho);
            arquivoUm.WriteLine(FormatoDeDataUm.ToString());
            arquivoUm.Close();
            var arquivoDois = new StreamWriter(terceiroCaminho);
            arquivoDois.WriteLine(FormatoDeDataDois.ToString());
            arquivoDois.Close();
            var arquivoTres = new StreamWriter(quartoCaminho);
            arquivoTres.WriteLine(FormatoDeDataTres.ToString());
            arquivoTres.Close();
        }
    }
}