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

        public void EscolhaDaMusica()
        {
            string[] EntradaMusicas;
            var soma = 0;
            var contador = 0;

            Console.WriteLine("");

            while (contador < _jogadas)
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

                EntradaMusicas = Console.ReadLine().Split(' ');

                var musicaUm = int.Parse(EntradaMusicas[0]);
                var musicaDois = int.Parse(EntradaMusicas[1]);
                soma = (musicaUm + musicaDois);
                Console.WriteLine("");


                if (soma < 0 || soma > 10)
                {
                    throw new EscolhaException();
               
                }
                else
                {
                    switch (soma)
                    {
                        case 0: Console.WriteLine("PROXYCITY\n"); break;
                        case 1: Console.WriteLine("P.Y.N.G.\n"); break;
                        case 2: Console.WriteLine("DNSUEY\n"); break;
                        case 3: Console.WriteLine("SERVERS\n"); break;
                        case 4: Console.WriteLine("HOST\n"); break;
                        case 5: Console.WriteLine("CRIPTONIZE\n"); break;
                        case 6: Console.WriteLine("OFFLINE DAY\n"); break;
                        case 7: Console.WriteLine("SALT\n"); break;
                        case 8: Console.WriteLine("ANSWER\n"); break;
                        case 9: Console.WriteLine("RAR?\n"); break;
                        case 10: Console.WriteLine("WIFI ANTENNAS\n"); break;
                    }
                    contador++;
                }
            }

            
        }
    }
}

