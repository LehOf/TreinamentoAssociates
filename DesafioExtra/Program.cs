using System;

namespace DesafioExtra
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine($"SELECIONE UMA OPÇÃO PARA O CALCULO SER REALIZADO / (1-2-3-4): ");
            Console.WriteLine("1 - CALCULADORA INDICE DE MASSA CORPORAL");
            Console.WriteLine("2 - CALCULADORA AREA DO CIRCULO");
            Console.WriteLine("3 - CALCULADORA REGRA DE 3");
            Console.WriteLine("4 - SAIR");
            int escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Menu menuCardapio = new Menu();
            menuCardapio.CardapioDeCalculo(escolha);
        }
    }
}

