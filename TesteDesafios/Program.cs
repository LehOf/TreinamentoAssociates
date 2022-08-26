using System;

namespace TesteDesafios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura do sapo e a quantidade de canos: ");
            string[] AlturaSapoQuantidadeCano = Console.ReadLine().Split(' ');

            var _alturaSapo = int.Parse(AlturaSapoQuantidadeCano[0]);
            var _quantidadesCanos = int.Parse(AlturaSapoQuantidadeCano[1]);

        }
    }
}

