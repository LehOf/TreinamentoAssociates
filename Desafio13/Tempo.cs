using System;
using System.Collections.Generic;

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
            List<int> lista = new List<int>();
            lista.Add(3600);
            lista.Add(60);

            var horas = 0;
            var minutos = 0;
            var segundos = 0;


            for(int i=0; i<1; i++)
            {
                horas = _tempo / lista[0];
                _tempo = _tempo % lista[0];

                minutos = _tempo / lista[1];
                _tempo = _tempo % lista[1];

                segundos = _tempo;              
            }

            Console.WriteLine($"{horas} : {minutos} : {segundos} ");
        }
    }
}
