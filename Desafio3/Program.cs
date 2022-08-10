using System;
using System.Globalization;

namespace Desafio3
{
    class Program
    {
        public const double pi = 3.14159;
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A= {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
