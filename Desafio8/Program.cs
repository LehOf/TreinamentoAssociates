using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE A HORA INICIAL E O MINUTO INICIAL A HORA FINAL E O MINUTO FINAL: ");
            string[] horario = Console.ReadLine().Split(' ');
            var horaInicial = int.Parse(horario[0]);
            var minutoInicial = int.Parse(horario[1]);
            var horaFinal = int.Parse(horario[2]);
            var minutoFinal = int.Parse(horario[3]);

            DuracaoDoJogo duracao = new DuracaoDoJogo();

            duracao.TotalDeHorasDoJogo();
            duracao.TotalDeMinutosDoJogo(horaInicial, minutoInicial, horaFinal, minutoFinal);

            Console.WriteLine($"O JOGO DUROU {duracao.TotalDeHorasDoJogo()} HORA(S) E {duracao.TotalDeMinutosDoJogo(horaInicial, minutoInicial, horaFinal, minutoFinal)} MINUTO(S)");
        }
    }
}
