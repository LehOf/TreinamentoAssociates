using System;
using System.IO;

namespace Desafio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O CAMINHO DO ARQUIVO: ");
            var caminho = Console.ReadLine();

            var arquivo = new Arquivo();
            arquivo.LendoArquivo(caminho);

            arquivo.CriandoNovosArquivos();

            Console.WriteLine(arquivo.FormatoDeDataUm);
            Console.WriteLine(arquivo.FormatoDeDataDois);
            Console.WriteLine(arquivo.FormatoDeDataTres);
        }
    }
}

