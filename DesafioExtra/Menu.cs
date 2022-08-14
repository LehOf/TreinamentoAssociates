using System;
using System.Globalization;

namespace DesafioExtra
{
    class Menu
    {
        public int escolha { get; set; }

        public void CardapioDeCalculo(int escolha)
        {
            string RegraDeTres;
            double calculo;

            switch (escolha)
            {
                case 1:
                    CalculadoraIMC calculoIMC = new CalculadoraIMC();
                    Console.Write("Informe seu peso: ");
                    calculoIMC.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Informe sua altura: ");
                    calculoIMC.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    calculoIMC.IndiceDeMassaCorporal();
                    break;
                case 2:
                    Console.Write("Informe o raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    CalculadoraAreaCirculo calculoCirculo = new CalculadoraAreaCirculo(raio);
                    calculo = calculoCirculo.AreaDoCirculo(raio);
                    Console.WriteLine(calculo.ToString("F2",CultureInfo.InvariantCulture));
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
