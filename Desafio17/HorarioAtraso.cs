using System;

namespace Desafio17
{
    class HorarioAtraso
    {
        private int _hora { get; set; }
        private int _minuto { get; set; }

        public HorarioAtraso(int hora, int minuto)
        {
            _hora = hora;
            _minuto = minuto;
        }

        public string AtrasoBino()
        {
            var resultado = "";
            var minutos = 0;
            var horas = 0;

            TimeSpan atraso, HorarioChegada, HorarioSaida, DuracaoMaxima, DuracaoMinima, HorarioLimiteMenor, HorarioLimiteMaior;

            atraso = new TimeSpan(0, 0, 0);
            HorarioChegada = new TimeSpan(8, 0, 0);
            HorarioSaida = new TimeSpan(_hora, _minuto, 0);
            DuracaoMaxima = new TimeSpan(1, 0, 0);
            DuracaoMinima = new TimeSpan(0, 30, 0);
            HorarioLimiteMenor = new TimeSpan(5, 0, 0);
            HorarioLimiteMaior = new TimeSpan(9, 0, 0);

            if (HorarioSaida >= HorarioLimiteMenor && HorarioSaida <= HorarioLimiteMaior)
            {
                if (HorarioSaida + (DuracaoMaxima) > HorarioChegada)
                {
                    atraso = HorarioSaida + (DuracaoMaxima);
                    atraso = atraso - HorarioChegada;
                    minutos = (int)atraso.TotalMinutes;
                    resultado = $"Atraso maximo: {minutos} minutos";
                }
                else if (HorarioSaida + (DuracaoMinima) < HorarioChegada)
                {
                    resultado = "Atraso maximo = 0";
                }
            }
            else
            {
                resultado = "Hoário fora do escopo limite";
            }
            return resultado;
        }

        public override string ToString()
        {
            return $"{AtrasoBino()}";
        }
    }
}
