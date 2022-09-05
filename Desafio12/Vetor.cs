using System;

namespace Desafio12
{
    class Vetor
    {
        private int _numeroDeposicoes { get; set; }
        private int _menor { get; set; }
        private int[] _posicoes { get; set; }

        public Vetor(int numeroDePosicoes)
        {
            _numeroDeposicoes = numeroDePosicoes;
        }

        public int EncontrarMenorValorDoVetor(int numeroDePosicao)
        {
            Console.Write("DIGITE AS POSIÇÕES DO VETOR: ");
            string[] posicoesDoVetor = Console.ReadLine().Split(' ');

            _posicoes = new int[numeroDePosicao];
            _menor = 1000;
            var maior = 1;

            for(int i=0; i<numeroDePosicao; i++)
            {
                _posicoes[i] = int.Parse(posicoesDoVetor[i]);

                if (_menor > _posicoes[i])
                {
                    _menor = _posicoes[i];
                }
                else if(maior < _posicoes[i])
                {
                    maior = _posicoes[i];
                }
            }

            return _menor;
        }

        public int EncontrarPosicaoMenorDoVetor(int numeroDePosicao)
        {
            var posicaoAlocada = 0;

            for(int i=0; i<numeroDePosicao; i++)
            {
                if(_posicoes[i] == _menor)
                {
                    posicaoAlocada = i;
                }
            }

            return posicaoAlocada;
        }


        public override string ToString()
        {
            return $"\n{EncontrarMenorValorDoVetor(_numeroDeposicoes)} \nPosição: {EncontrarMenorValorDoVetor(_numeroDeposicoes)}";
        }
    }
}


