using System;

namespace Desafio19
{
    class Musica
    {
        private int _jogadas { get; set; }

        public Musica(int jogadas)
        {
            _jogadas = jogadas;
        }

        public string MusicasMaisTocadas()
        {
            var somaMusica = EscolhaDaMusicaUsuario();
            return VerificarMusicaEscolhidaUsuario(somaMusica); ;
        }

        public int EscolhaDaMusicaUsuario()
        {
            string[] entradaMusicas;

            Console.Write("ESCOLHA DUAS MUSICA: \n" +
                "0 - PROXYCITY \n" +
                "1 - P.Y.N.G.\n" +
                "2 - DNSUEY! \n" +
                "3 - SERVERS \n" +
                "4 - HOST! \n" +
                "5 - CRIPTONIZE \n" +
                "6 - OFFLINE DAY \n" +
                "7 - SALT \n" +
                "8 - ANSWER! \n" +
                "9 - RAR? \n" +
                "10 - WIFI ANTENNAS \n\n");

            entradaMusicas = Console.ReadLine().Split(' ');

            var musicaUm = int.Parse(entradaMusicas[0]);
            var musicaDois = int.Parse(entradaMusicas[1]);

            return musicaUm + musicaDois;

        }


        public string VerificarMusicaEscolhidaUsuario(int soma)
        {
            if (soma < 0 || soma > 10)
            {
                throw new EscolhaException();
            }

            switch (soma)
            {
                case 0: return FaixasMusicais.FaixaZero;
                case 1: return FaixasMusicais.FaixaUm; ;
                case 2: return FaixasMusicais.FaixaDois;
                case 3: return FaixasMusicais.FaixaTres;
                case 4: return FaixasMusicais.FaixaQuatro;
                case 5: return FaixasMusicais.FaixaCinco;
                case 6: return FaixasMusicais.FaixaSeis;
                case 7: return FaixasMusicais.FaixaSete;
                case 8: return FaixasMusicais.FaixaOito;
                case 9: return FaixasMusicais.FaixaNove;
                case 10: return FaixasMusicais.FaixaDez;
                default: return string.Empty;
            }
        }
    }
}

