using System;

namespace Desafio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o horário que o Bino acordou?");
            string[] valores = Console.ReadLine().Split(':');
            int horas = int.Parse(valores[0]);
            int minutos = int.Parse(valores[1]);

            HorarioAtraso horario = new HorarioAtraso(horas, minutos);

            Console.WriteLine(horario.AtrasoBino());

        }

        }
}
