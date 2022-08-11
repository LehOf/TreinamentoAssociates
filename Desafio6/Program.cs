using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Tabuada tabuada = new Tabuada();

            tabuada.CalculoTabuada(N);

        }
    }
}
