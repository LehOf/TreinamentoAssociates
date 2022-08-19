using System;
using System.Globalization;

namespace Desafio11
{
    class ImpostoDeRenda
    {
        private double _salario { get; set; }

        public ImpostoDeRenda(double salario)
        {
            _salario = salario;
        }

        public double CalculovalorImposto(double salario)
        {
            var valorImposto = 0.0;
            var primeiraFaixaSalarial = new[] { 0.0, 2000.00 };
            var segundaFaixaSalarial = new[] { 2000.01, 3000.00 };
            var terceiraFaixaSalarial = new[] { 3000.01, 4500.00 };

            if (salario > primeiraFaixaSalarial[0] && salario <= primeiraFaixaSalarial[1])
            {
                valorImposto = 0.0;
            }
            else if (salario > segundaFaixaSalarial[0] && salario <= segundaFaixaSalarial[1])
            {
                valorImposto = (salario - 2000) * 0.08;
            }
            else if (salario > terceiraFaixaSalarial[0] && salario <= terceiraFaixaSalarial[1])
            {
                valorImposto = (salario - 3000) * 0.18 + (1000 * 0.08);
            }
            else if (salario > terceiraFaixaSalarial[1])
            {
                valorImposto = (salario - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
            }
            return valorImposto;
        }

        public override string ToString()
        {
            var RetornoImposto = CalculovalorImposto(_salario) == 0.0 ? "Isento" : $"R$ {CalculovalorImposto(_salario).ToString("F2", CultureInfo.InvariantCulture)}";
            return RetornoImposto;  
        }
    }
}
