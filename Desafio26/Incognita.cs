using System;

namespace Desafio26
{
    class Incognita
    {
        private string[] _equacao { get; set; }

        public Incognita(string[] equacao)
        {
            _equacao = equacao;
        }

        public void CalcularEquacao()
        {
            string[] separadorStringInt = new string[_equacao.Length];
            int[] valores = new int[_equacao.Length];

            var resultado = 0;

            separadorStringInt[0] = (_equacao[0]);
            separadorStringInt[1] = (_equacao[1]);
            separadorStringInt[2] = (_equacao[2]);

            var primeiraVariavel = "R";
            var segundaVariavel = "L";
            var terceiraVariavel = "J";


            if (separadorStringInt[0] == primeiraVariavel && separadorStringInt[1] != segundaVariavel)
            {
                valores[1] = int.Parse(_equacao[1]);
                valores[2] = int.Parse(_equacao[2]);

                resultado = valores[2] - valores[1];
                Console.WriteLine(resultado);
            }
            else if (separadorStringInt[0] != primeiraVariavel && separadorStringInt[1] == segundaVariavel)
            {
                valores[0] = int.Parse(_equacao[0]);
                valores[2] = int.Parse(_equacao[2]);

                resultado = valores[2] - valores[0];
                Console.WriteLine(resultado);
            }
            else if (separadorStringInt[0] != primeiraVariavel && separadorStringInt[1] != segundaVariavel && separadorStringInt[2] == terceiraVariavel)
            {
                valores[0] = int.Parse(_equacao[0]);
                valores[1] = int.Parse(_equacao[1]);

                resultado = valores[0] + valores[1];
                Console.WriteLine(resultado);
            }
        }
    }
}
