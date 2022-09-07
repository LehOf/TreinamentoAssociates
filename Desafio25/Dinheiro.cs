﻿using System;
using System.Globalization;

namespace Desafio25
{
    class Dinheiro
    {
        private double _dinheiro { get; set; }
        private double _resto { get; set; }

        public Dinheiro(double dinheiro)
        {
            _dinheiro = dinheiro;
        }

        public void CalcularNotas()
        {
            double[] notasQuantidades = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00 };
            double[] notasValores = { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00 };

            Console.WriteLine("NOTAS: ");

            for (int i = 0; i < notasQuantidades.Length; i++)
            {
                if (notasQuantidades[i] != notasQuantidades[0])
                {
                    notasQuantidades[i] = _resto / notasValores[i];
                    _resto %= notasValores[i];
                }
                else
                {
                    notasQuantidades[i] = _dinheiro / notasValores[i];
                    _resto = _dinheiro % notasValores[i];
                }
                Console.WriteLine($"{(int)notasQuantidades[i]} nota(s) de R$ {notasValores[i].ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

        public void CalcularMoedas()
        {
            double[] moedasValores = { 1.0, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double[] moedasQuantidades = { 1.0, 0.50, 0.25, 0.10, 0.05, 0.01 };

            Console.WriteLine("MOEDAS: ");

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
                Console.WriteLine($"{(int)moedasQuantidades[i]} nota(s) de R$ {moedasValores[i].ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}

