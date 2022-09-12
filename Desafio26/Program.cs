using System;

namespace Desafio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UMA ENTRADA VÁLIDA: ");
            string[] equacao = Console.ReadLine().ToUpper().Split('+', '=');

            var incognita = new Incognita(equacao);

            incognita.CalcularEquacao();
        }
    }
}
