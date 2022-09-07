using System;
using System.Globalization;
using Desafio25.Exceptions;

namespace Desafio25
{
    public class Dinheiro
    {
        private double _dinheiro { get; set; }
        private double _resto { get; set; }

        public Dinheiro(double dinheiro)
        {
            _dinheiro = dinheiro;
        }

        public void TratarExcecao()
        {
            var error = new EntradaInvalidaException();
            Console.WriteLine(error.Message);
        }
        public string CalcularNotas()
        {
            double[] notasQuantidades = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00 };
            double[] notasValores = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00 };

            var resultado = "";

            for (int i = 0; i < notasQuantidades.Length; i++)
            {
                if (notasQuantidades[i] != notasValores[0])
                {
                    notasQuantidades[i] = _resto / notasValores[i];
                    _resto %= notasValores[i];
                }
                else
                {
                    notasQuantidades[i] = _dinheiro / notasValores[i];
                    _resto = _dinheiro % notasValores[i];
                }
            }

            for (int i = 0; i < notasQuantidades.Length; i++)
            {
                resultado += ($"{(int)notasQuantidades[i]} nota(s) de R$ {notasValores[i].ToString("F2", CultureInfo.InvariantCulture)}\n");
            }
            return resultado;
        }
        public string CalcularMoedas()
        {
            double[] moedasValores = { 1.0, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double[] moedasQuantidades = { 1.0, 0.50, 0.25, 0.10, 0.05, 0.01 };

            var resultado = "";

            for (int i = 0; i < moedasQuantidades.Length; i++)
            {
                if (moedasQuantidades[i] != moedasQuantidades[0])
                {
                    moedasQuantidades[i] = _resto / (moedasValores[i] * 100);
                    _resto %= (moedasValores[i] * 100);
                }
                else
                {
                    moedasQuantidades[i] = _resto / moedasValores[i];
                    _resto %= moedasValores[i];
                    _resto *= 100;
                }
            }
            for (int i = 0; i < moedasQuantidades.Length; i++)
            {
                resultado += ($"{(int)moedasQuantidades[i]} moeda(s) de R$ {moedasValores[i].ToString("F2", CultureInfo.InvariantCulture)}\n");
            }
            return resultado;
        }
    }
}

