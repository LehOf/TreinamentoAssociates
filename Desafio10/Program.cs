using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Digite a primeira especie: ");
            string _primeiraEspecie = Console.ReadLine().ToLower();
            Console.Write("Digite a segunda especie: ");
            string _segundaEspecie = Console.ReadLine().ToLower();
            Console.Write("Digite a terceira especie: ");
            string _terceiraEspecie = Console.ReadLine().ToLower();
            Console.WriteLine("");

            ReinoAnimal especie = new ReinoAnimal(_primeiraEspecie, _segundaEspecie, _terceiraEspecie);
  
            var especieFinal = especie.EspecieVertebradosInvertebrados(_primeiraEspecie);

            Console.WriteLine($"{especie}");

            
        }
    }
}
