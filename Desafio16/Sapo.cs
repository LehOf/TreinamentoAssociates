using System;

namespace Desafio16
{
    class Sapo
    {
        private int _alturaSapo { get; set; }
        private int _quantidadesCanos { get; set; }
        private int[] _alturaCanos { get; set; }

        public Sapo(int altura, int quantidadesCanos)
        {
            _alturaSapo = altura;
            _quantidadesCanos = quantidadesCanos;
        }

        public string CalcularPuloSapo()
        {
            var resultado = "";
            int resposta = 0;
            int[] anterior = new int[_quantidadesCanos];

            _quantidadesCanos--;

            Console.Write("DIGITE AS ALTURAS DOS CANOS:  ");
            string[] valordaaltura = Console.ReadLine().Split(' ');
            for (int i = 0; i <= _quantidadesCanos; i++)
            {
                anterior[i] = int.Parse(valordaaltura[i]);            
            }

            for (int i = 0; i < _quantidadesCanos; i++)
            {
                if ((anterior[i + 1] - anterior[i]) > _alturaSapo)
                {
                    resposta = 1;
                    break;
                }
            }

            return resposta != 0 ? resultado = "GAME OVER" : resultado = "YOU WIN";
                
        }

    }
}
            


