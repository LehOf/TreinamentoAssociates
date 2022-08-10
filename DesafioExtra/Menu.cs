using System;
using System.Globalization;

namespace DesafioExtra
{
    class Menu
    {
        public int escolha { get; set; }

        public void CardapioDeCalculo(int escolha)
        {
            string ClassificacaoDoIMC;
            string AreaDoCirculo;
            string RegraDeTres;

            switch (escolha)
            {
                case 1:
                    Console.Write("Informe seu peso: ");
                    double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Informe sua altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    CalculadoraIMC calculoIMC = new CalculadoraIMC(peso, altura);
                    ClassificacaoDoIMC = calculoIMC.IndiceDeMassaCorporal();
                    Console.WriteLine(ClassificacaoDoIMC);
                    break;
                case 2:
                    Console.Write("Informe o raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    CalculadoraAreaCirculo calculoCirculo = new CalculadoraAreaCirculo(raio);
                    AreaDoCirculo = calculoCirculo.AreaDoCirculo();
                    Console.WriteLine(AreaDoCirculo);
                    break;
                case 3:
                    Console.Write("Informe o primeiro valor: ");
                    double primeiroValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Informe o segundo valor: ");
                    double segundoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Informe o terceiro valor: ");
                    double terceiroValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    CalculadoraRegraDeTres calculoRegraDeTres = new CalculadoraRegraDeTres(primeiroValor, segundoValor, terceiroValor);
                    RegraDeTres = calculoRegraDeTres.RegraDeTres();
                    Console.WriteLine(RegraDeTres);
                    break;
                case 4:
                    Console.WriteLine("PROGRAMA FINALIZADO COM SUCESSO");
                    break;
                default:
                    Console.WriteLine("ESCOLHA UMA OPÇÃO VÁLIDA");
                    break;         
            }
        }
    }
}
