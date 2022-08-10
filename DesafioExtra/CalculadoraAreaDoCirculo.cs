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

        public double AreaDoCirculo(double raio)
        {
            double ValorFinal;
            ValorFinal = PI * Math.Pow(Raio, 2);
            return ValorFinal;
        }
    }
}
