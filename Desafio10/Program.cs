using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            var especieFinal = "";

            Console.Write("Digite a primeira especie: ");
            string _primeiraEspecie = Console.ReadLine().ToLower();
            Console.Write("Digite a segunda especie: ");
            string _segundaEspecie = Console.ReadLine().ToLower();
            Console.Write("Digite a terceira especie: ");
            string _terceiraEspecie = Console.ReadLine().ToLower();
            Console.WriteLine("");

            ReinoAnimal especie = new ReinoAnimal(_primeiraEspecie, _segundaEspecie, _terceiraEspecie);

            if (_primeiraEspecie == "vertebrado")
            {
                especieFinal = especie.EspecieDosVertebrados();
            }
            else if (_primeiraEspecie == "invertebrado")
            {
                especieFinal = especie.EspeciesDosInvertebrados();
            }

            Console.WriteLine($"{especieFinal}");
        }
    }
}
