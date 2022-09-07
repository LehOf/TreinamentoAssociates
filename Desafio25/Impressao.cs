using System;

namespace Desafio25
{
    class Impressao
    {
        private Dinheiro _dinheiro { get; set; }

        public Impressao(Dinheiro dinheiro)
        {
            _dinheiro = dinheiro;
        }

        public void ImprimirNotasMoedas()
        {
            Console.WriteLine($"NOTAS:\n{_dinheiro.CalcularNotas()} ");
            Console.WriteLine($"MOEDAS:\n{_dinheiro.CalcularMoedas()} ");
        }
    }
}
