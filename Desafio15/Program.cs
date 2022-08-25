using System;

namespace Desafio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor interio X: ");
            var primeiroValor = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro Y: ");
            var segundoValor = int.Parse(Console.ReadLine());

            NumerosImpares numerosImpares = new NumerosImpares(primeiroValor, segundoValor);

            numerosImpares.SomaDosNumerosImpares();

            Console.WriteLine(numerosImpares);
        }
    }
}
