using System;
using System.Globalization;

namespace Desafio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE SEU SALÁRIO: ");
            var salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ImpostoDeRenda imposto = new ImpostoDeRenda(salario);

            Console.WriteLine($"{imposto.CalculovalorImposto(salario)}");
        }
    }
}
