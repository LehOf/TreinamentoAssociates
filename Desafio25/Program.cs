using System;
using System.Globalization;

namespace Desafio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE UM VALOR: ");
            var entradaDinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var dinheiro = new Dinheiro(entradaDinheiro);
            dinheiro.TratarExcecao();
        }
    }
}
