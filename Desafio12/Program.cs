using System;

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE A QUANTIDADE DE POSIÇOES DO VETOR: ");
            int numeroDePosicoes = int.Parse(Console.ReadLine());

            Vetor vetor = new Vetor(numeroDePosicoes);

            Console.WriteLine(vetor);
        }
    }
}
