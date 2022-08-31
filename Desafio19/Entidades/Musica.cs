using System;

namespace Desafio19
{
    class Musica
    {
        private int _jogadas { get; set; }
        private int _soma { get; set; }
        private int _contador { get; set; }

        public Musica(int jogadas)
        {
            _jogadas = jogadas;
        }

        public int EscolhaDaMusica()
        {
            string[] entradaMusicas;
            var soma = 0;

            do
            {
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
                soma = (musicaUm + musicaDois);
                _contador++;
            } while (_contador < _jogadas);

            return soma;
        }


        public string MusicaEscolhida()
        {
            var resultado = "";
            FaixasMusicais faixas = new FaixasMusicais();

            if (_soma < 0 || _soma > 10)
            {
                throw new EscolhaException();
            }
            else
            {
                switch (_soma)
                {
                    case 0: resultado = faixas.faixaZero; break;
                    case 1: resultado = faixas.faixaUm; break;
                    case 2: resultado = faixas.faixaDois; break;
                    case 3: resultado = faixas.faixaTres; break;
                    case 4: resultado = faixas.faixaQuatro; break;
                    case 5: resultado = faixas.faixaCinco; break;
                    case 6: resultado = faixas.faixaSeis; break;
                    case 7: resultado = faixas.faixaSete; break;
                    case 8: resultado = faixas.faixaOito; break;
                    case 9: resultado = faixas.faixaNove; break;
                    case 10: resultado = faixas.faixaDez; break;
                }
                
            }
            return resultado;
        }
    }
}

