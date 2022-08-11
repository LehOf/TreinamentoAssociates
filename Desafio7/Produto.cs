using System;
using System.Globalization;

namespace Desafio7
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double Total()
        {
            double PrecoFinal = 0;

            switch (Codigo)
            {
                case 1:
                    PrecoFinal = 4.00 * Quantidade;
                    break;
                case 2:
                    PrecoFinal = 4.50 * Quantidade;
                    break;
                case 3:
                    PrecoFinal = 5.00 * Quantidade;
                    break;
                case 4:
                    PrecoFinal = 2.00 * Quantidade;
                    break;
                case 5:
                    PrecoFinal = 1.50 * Quantidade;
                    break;
            }
            return PrecoFinal;
        }

        public override string ToString()
        {
            return "Total: R$ " + Total().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
