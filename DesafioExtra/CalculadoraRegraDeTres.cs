using System;
using System.Globalization;

namespace DesafioExtra
{
    class CalculadoraRegraDeTres
    {
        public double PrimeiroValor { get; set; }
        public double SegundoValor { get; set; }
        public double TerceiroValor { get; set; }
        public double Incognita { get; set; }

        public CalculadoraRegraDeTres(double primeiroValor, double segundoValor, double terceiroValor)
        {
            PrimeiroValor = primeiroValor;
            SegundoValor = segundoValor;
            TerceiroValor = terceiroValor;
        }

        public string RegraDeTres()
        {
            string respostaFinal;
            double incognita = (PrimeiroValor * TerceiroValor) / SegundoValor;

           return respostaFinal = ($"O valor da incognita é: {incognita.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
