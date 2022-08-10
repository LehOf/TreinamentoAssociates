using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int DiscagemDireta = int.Parse(Console.ReadLine());
            DiscagemDiretaDistancia discagemdiretadistancia = new DiscagemDiretaDistancia(DiscagemDireta);
            Console.WriteLine(discagemdiretadistancia.RetornaCidade());
        }
    }
}
