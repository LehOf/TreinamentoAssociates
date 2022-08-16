using System;
using System.Globalization;

namespace Desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRE COM O SALÁRIO: ");
            var salarioDoFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Salario salario = new Salario(salarioDoFuncionario);

            salario.ReajusteSalarial();
            salario.ReajusteGanho();

            Console.WriteLine(salario);
        }
    }
}
