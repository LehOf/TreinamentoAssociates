using System;
using System.IO;

namespace Desafio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo:");
            var SourcePath = Console.ReadLine();

            var arquivo = new Arquivo(SourcePath);

           arquivo.ImprimirNoConsole();

        }
    }
}

