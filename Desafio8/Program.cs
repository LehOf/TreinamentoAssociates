using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horario = Console.ReadLine().Split(' ');
            var horaInicial = int.Parse(horario[0]);
            var minutoInicial = int.Parse(horario[1]);
            var horaFinal = int.Parse(horario[2]);
            var minutoFinal = int.Parse(horario[3]);

            DuracaoDoJogo duracao = new DuracaoDoJogo(horaInicial,minutoInicial, horaFinal, minutoFinal);

            duracao.TotalDeHorasDoJogo();
            duracao.TotalDeMinutosDoJogo();

            Console.WriteLine(duracao);
        }
    } 
}
