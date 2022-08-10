using System;
using System.Globalization;

namespace DesafioExtra
{
    class CalculadoraAreaCirculo
    {
        const double PI = 3.14;
        public double Raio { get; set; }

        public CalculadoraAreaCirculo(double raio)
        {
            Raio = raio;
        }

        public string AreaDoCirculo()
        {
            double ValorFinal;
            string Area = "";
            ValorFinal = PI * Math.Pow(Raio, 2);

            return Area = ($"A area do circulo é: {ValorFinal.ToString("F2", CultureInfo.InvariantCulture)} cm²");
        }
    }
}
