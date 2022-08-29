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
            int valor, resposta = 0;
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




            return resposta != 0 ? resultado = "GAME OVER\n" : resultado = "YOU WIN\n";
                
        }

    }
}
            


    //int valor = 0, subtracao = 0;

    //Console.Write("Digite as alturas dos canos: ");
    //string[] EntradaAlturaDosCanos = Console.ReadLine().Split(' ');

    //_alturaCanos = new int[_quantidadesCanos];

    //for (int i = 0; i < _quantidadesCanos; i++)
    //{
    //    _alturaCanos[i] = int.Parse(EntradaAlturaDosCanos[i]);
    //}

    //for (int i = 1; i < _quantidadesCanos; i++)
    //{
    //    _ = _alturaCanos[i] > _alturaCanos[i + 1] ? subtracao = (_alturaCanos[i] - _alturaCanos[i - 1]) : subtracao = (_alturaCanos[i + 1] - _alturaCanos[i]);
    //}

    //if (subtracao <= _alturaSapo)
    //{
    //    valor++;
    //}
    //return ( == _alturaSapo - 1) ? "GAME OVER" : "YOU WIN";


