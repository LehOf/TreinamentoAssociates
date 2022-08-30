using System;

namespace Desafio18
{
    class Jogo
    {
        private int _jogadas { get; set; }

        public Jogo(int jogadas)
        {
            _jogadas = jogadas;
        }

        public void RegraDoJogo()
        {
            var resultado = "";

            for (int i = 0; i <_jogadas; i++)
            {
                Console.Write("ESCOLHA UMA OPÇÃO - (PEDRA/PAPEL/ATAQUE): ");
                var escolha = Console.ReadLine().ToLower();

                Console.Write("ESCOLHA UMA OPÇÃO - (PEDRA/PAPEL/ATAQUE): ");
                var escolha2 = Console.ReadLine().ToLower();
                
                if (escolha == "pedra" && escolha2 == "pedra")
                {
                    resultado = "Sem ganhador";
                }
                else if (escolha == "papel" && escolha2 == "papel")
                {
                    resultado = "Ambos ganharam";
                }
                else if (escolha == "ataque" && escolha2 == "ataque")
                {
                    resultado = "Aniquilação Mútua";
                }
                else if (escolha == "pedra" && escolha2 == "papel")
                {
                    resultado = "Jogador 1 venceu";
                }
                else if (escolha == "papel" && escolha2 == "pedra")
                {
                    resultado = "Jogador 2 venceu";
                }
                else if (escolha == "ataque" && escolha2 == "pedra")
                {
                    resultado = "Jogador 1 venceu";
                }
                else if (escolha == "pedra" && escolha2 == "ataque")
                {
                    resultado = "Jogador 2 venceu";
                }
                else if (escolha == "ataque" && escolha2 == "papel")
                {
                    resultado = "Jogador 1 venceu";
                }
                else if (escolha == "papel" && escolha2 == "ataque")
                {
                    resultado = "Jogador 2 venceu";
                }
                Console.WriteLine(resultado);
                Console.WriteLine("");
            }
        }
    }
}
