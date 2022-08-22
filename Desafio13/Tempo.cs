using System;

namespace Desafio13
{
    class Tempo
    {
        private int _tempo { get; set; }

        public Tempo(int tempo)
        {
            _tempo = tempo;
        }

        public void ConversaoDoTempo()
        {
            var horas = _tempo / 3600;
            _tempo = _tempo % 3600;

            var minutos = _tempo / 60;
            _tempo = _tempo % 60;

            var segundos = _tempo;

            Console.WriteLine($"{horas} : {minutos} : {segundos} ");
        }
    }
}
