using System;
using System.Globalization;

namespace Desafio9
{
    class Salario
    {
        public double SalarioDoFuncionario { get; private set; }
        public int Porcentagem { get; set; }

        public Salario(double salario)
        {
            SalarioDoFuncionario = salario;
        }

        public double ReajusteSalarial()
        {
            var salario = 0.0;

            if (SalarioDoFuncionario > 0 && SalarioDoFuncionario <= 400.00)
            {
                salario = SalarioDoFuncionario * 0.15 + SalarioDoFuncionario;
                Porcentagem = 15;
            }
            else if (SalarioDoFuncionario >= 400.01 && SalarioDoFuncionario <= 800.00)
            {
                salario = SalarioDoFuncionario * 0.12 + SalarioDoFuncionario;
                Porcentagem = 12;
            }
            else if (SalarioDoFuncionario >= 800.01 && SalarioDoFuncionario <= 1200.00)
            {
                salario = SalarioDoFuncionario * 0.10 + SalarioDoFuncionario;
                Porcentagem = 10;
            }
            else if (SalarioDoFuncionario >= 1200.01 && SalarioDoFuncionario <= 2000.00)
            {
                salario = SalarioDoFuncionario * 0.07 + SalarioDoFuncionario;
                Porcentagem = 7;
            }
            else
            {
                salario = SalarioDoFuncionario * 0.04 + SalarioDoFuncionario;
                Porcentagem = 4;
            }
            return salario;
        }

        public int PorcentualDoReajuste()
        {
            var AumentoEmPorcentagem = 0;

            switch (Porcentagem)
            {
                case 15:
                    AumentoEmPorcentagem = 15;
                    break;
                case 12:
                    AumentoEmPorcentagem = 12;
                    break;
                case 10:
                    AumentoEmPorcentagem = 10;
                    break;
                case 7:
                    AumentoEmPorcentagem = 7;
                    break;
                case 4:
                    AumentoEmPorcentagem = 4;
                    break;
                default:
                    Console.WriteLine("Não houve aumento");
                    break;
            }
            return AumentoEmPorcentagem;
        }

        public double ReajusteGanho()
        {
            var reajusteGanho = 0.0;
            return reajusteGanho = ReajusteSalarial() - SalarioDoFuncionario;
        }

        public override string ToString()
        {
            return ($"Novo Salario: {ReajusteSalarial().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"\nReajuste ganho: {ReajusteGanho().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"\nEm percentual: {PorcentualDoReajuste()} %");
        }

    }
}

