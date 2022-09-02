using Desafio22.Excecoes;
using System;

namespace Desafio22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("DIGITE O NÚMERO DE JOGADAS: ");
                var jogadas = int.Parse(Console.ReadLine());

                Console.Write("DIGITE UM CARACTER VÁLIDO A/B/C: ");
                var PosicaoInicialDaMoeda = Console.ReadLine().ToUpper();

                var PosicaoDaMoeda = new JogoDaMoeda(jogadas);

                Console.WriteLine(PosicaoDaMoeda.PosicaoFinal(PosicaoInicialDaMoeda));

            }
            catch (CaracterInvalidoException e)
            {
                Console.WriteLine("ERRO NO CARÁCTER: " + e.Message);
            }
        }
    }
}
