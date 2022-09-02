using Desafio22.Excecoes;
using System;

namespace Desafio22
{
    class JogoDaMoeda : IPosicoes
    {
        private int _jogadas { get; set; }

        public JogoDaMoeda(int jogadas)
        {
            _jogadas = jogadas;
        }

        public string PosicaoFinal(string PosicaoInicialDaMoeda)
        {
            var contador = 0;

            if (PosicaoInicialDaMoeda != "A" && PosicaoInicialDaMoeda != "B" && PosicaoInicialDaMoeda != "C")
            {
                throw new CaracterInvalidoException();
            }

            while (contador < _jogadas)
            {
                Console.Write("Digite um movimento 1/2/3: ");
                var movimentos = int.Parse(Console.ReadLine());


                if (movimentos == 1 && PosicaoInicialDaMoeda == "A")
                {
                    PosicaoInicialDaMoeda = "B";
                }
                else if (movimentos == 1 && PosicaoInicialDaMoeda == "B")
                {
                    PosicaoInicialDaMoeda = "A";
                }
                else if (movimentos == 2 && PosicaoInicialDaMoeda == "C")
                {
                    PosicaoInicialDaMoeda = "B";
                }
                else if (movimentos == 2 && PosicaoInicialDaMoeda == "B")
                {
                    PosicaoInicialDaMoeda = "C";
                }
                else if (movimentos == 3 && PosicaoInicialDaMoeda == "A")
                {
                    PosicaoInicialDaMoeda = "C";
                }
                else if (movimentos == 3 && PosicaoInicialDaMoeda == "C")
                {
                    PosicaoInicialDaMoeda = "A";
                }
                contador++;
            }

            return PosicaoInicialDaMoeda;
        }
    }

}
