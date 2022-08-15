using System;

namespace Desafio8
{
    class DuracaoDoJogo
    {
        public int Tempo { get; set; }
        public int TotalDeMinutosDoJogo(int horaInicial, int minutoInicial, int horaFinal, int minutoFinal)
        {
            var minutosTotais = 0;

            minutoInicial += horaInicial * 60;
            minutoFinal += horaFinal * 60;

            Tempo = minutoFinal - minutoInicial;

            if (Tempo <= 0)
            {
                Tempo += 24 * 60;
            }

            return minutosTotais = Tempo % 60;
        }

        public int TotalDeHorasDoJogo()
        {
            var horasTotais = 0;

            return horasTotais = Tempo / 60;
        }
    }
}