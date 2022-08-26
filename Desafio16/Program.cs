using System;

namespace Desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura do pulo do Sapo e a quantidade de canos: ");
            string[] AlturaQuantidade = Console.ReadLine().Split(' ');

            var alturaSapo = int.Parse(AlturaQuantidade[0]);
            var quantidadeCanos = int.Parse(AlturaQuantidade[1]);

            Sapo sapo = new Sapo(alturaSapo, quantidadeCanos);

           
            Console.WriteLine(sapo.Calcular());

        }
    }
}
