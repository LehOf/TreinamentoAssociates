using System;

namespace Desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            string[] Codigo_Quantidade = Console.ReadLine().Split(' ');

            produto.Codigo = int.Parse(Codigo_Quantidade[0]);
            produto.Quantidade = int.Parse(Codigo_Quantidade[1]);

            produto.Total();

            Console.WriteLine($"{produto}");
            
        }
    }
}
