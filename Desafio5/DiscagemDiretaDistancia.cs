using System;

namespace Desafio5
{
    class DiscagemDiretaDistancia
    {
        public int Discagem_direta_distancia { get; set; }

        public DiscagemDiretaDistancia(int discagemdireta)
        {
            Discagem_direta_distancia = discagemdireta;
        }

        public string RetornaCidade()
        {
            string cidade = "";

            if (Discagem_direta_distancia == 61)
            {
                cidade = "Brasilia";
            }
            else if (Discagem_direta_distancia == 71)
            {
                cidade = "Salvador";
            }
            else if (Discagem_direta_distancia == 11)
            {
                cidade = "Sao Paulo";
            }
            else if (Discagem_direta_distancia == 21)
            {
                cidade = "Rio de Janeiro";
            }
            else if (Discagem_direta_distancia == 32)
            {
                cidade = "Juiz de Fora";
            }
            else if (Discagem_direta_distancia == 19)
            {
                cidade = "Campinas";
            }
            else if (Discagem_direta_distancia == 27)
            {
                cidade = "Vitoria";
            }
            else if (Discagem_direta_distancia == 31)
            {
                cidade = "Belo Horizonte";
            }
            else
            {
                cidade = "DDD não cadastrado";
            }

            return cidade;
        }
    }
}
