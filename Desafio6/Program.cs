using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                double Resultado = i * N;
                Console.WriteLine($"{i} X {N} = {Resultado} ");
            }
        }


    }
}
