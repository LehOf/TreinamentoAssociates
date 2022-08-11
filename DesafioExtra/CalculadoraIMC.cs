using System;
using System.Globalization;

namespace DesafioExtra
{
    class CalculadoraIMC
    {
        public double Peso { get; set; }
        public double Altura { get; set; }

        public CalculadoraIMC()
        {

        }
        public CalculadoraIMC(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }


        public string IndiceDeMassaCorporal()
        {
            double IMC;
            string classificacao = "";
            IMC = Peso / Math.Pow(Altura, 2);

            if (IMC <= 18.5)
            {
                classificacao = ($"Seu IMC é: {IMC.ToString("F2", CultureInfo.InvariantCulture)} SUA CLASSIFICAÇÃO: ABAIXO DO PESO");
            }
            else if (IMC > 18.5 && IMC <= 24.9)
            {
                classificacao = ($"Seu IMC é: {IMC.ToString("F2", CultureInfo.InvariantCulture)} SUA CLASSIFICAÇÃO: PESO NORMAL");
            }
            else if (IMC > 25.0 && IMC <= 29.9)
            {
                classificacao = ($"Seu IMC é: {IMC.ToString("F2", CultureInfo.InvariantCulture)} SUA CLASSIFICAÇÃO: ACIMA DO PESO (SOBREPESO)");
            }
            else if (IMC > 30.0 && IMC <= 34.9)
            {
                classificacao = ($"Seu IMC é: {IMC.ToString("F2", CultureInfo.InvariantCulture)} SUA CLASSIFICAÇÃO: OBESIDADE I");
            }
            else if (IMC > 35 && IMC <= 39.9)
            {
                classificacao = ($"Seu IMC é: {IMC.ToString("F2", CultureInfo.InvariantCulture)} SUA CLASSIFICAÇÃO: OBESIDADE II");
            }
            else if (IMC > 40)
            {
                classificacao = ($"Seu IMC é: {IMC.ToString("F2", CultureInfo.InvariantCulture)} SUA CLASSIFICAÇÃO OBESIDADE III");
            }
            return classificacao;
        }
    }
}
