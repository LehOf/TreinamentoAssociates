using System;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE UM TEMPO EM SEGUNDOS: ");
            var tempoEmSegundos = int.Parse(Console.ReadLine());

            Tempo tempo = new Tempo(tempoEmSegundos);

            tempo.ConversaoDoTempo();
        }
    }
}
