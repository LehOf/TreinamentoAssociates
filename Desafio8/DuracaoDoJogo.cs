using System;

namespace Desafio8
{
    class DuracaoDoJogo
    {
        public int HoraInicial { get; set; }
        public int MinutoInicial { get; set; }
        public int HoraFinal { get; set; }
        public int MinutoFinal { get; set; }
        public int Tempo { get; set; }

        public DuracaoDoJogo(int horaInicial, int minutoIncial, int horaFinal, int minutoFinal)
        {
            HoraInicial = horaInicial;
            MinutoInicial = minutoIncial;
            HoraFinal = horaFinal;
            MinutoFinal = minutoFinal;
        }

        public int TotalDeMinutosDoJogo()
        {
            var minutosTotais = 0;

            MinutoInicial += HoraInicial * 60;
            MinutoFinal += HoraFinal * 60;

            Tempo = MinutoFinal - MinutoInicial;

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

        public override string ToString()
        {
            return ($"O JOGO DUROU {TotalDeHorasDoJogo()} HORA(S) E {TotalDeMinutosDoJogo()} MINUTO(S)");
        }
       
    }
}
