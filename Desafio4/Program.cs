using System;
using System.Globalization;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroFunc = int.Parse(Console.ReadLine());
            int Horas = int.Parse(Console.ReadLine());
            double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = Horas * Valor;

            Console.WriteLine($"NUMBER = {NumeroFunc} \nSALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
