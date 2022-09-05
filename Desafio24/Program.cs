using System;

namespace Desafio24
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("DIGITE A DIMENSÃO DO TABULEIRO EXEMPLO NxN:");
            var numeroDaDimensao = int.Parse(Console.ReadLine());

            var tabuleiro = new Tabuleiro();
            var exportar = new ExportandoConsole();

            tabuleiro.TratarEntrada(numeroDaDimensao);

            exportar.Exportando(tabuleiro, numeroDaDimensao);     
        }
    }
}

