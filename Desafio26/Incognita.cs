using System;

namespace Desafio26
{
    class Incognita
    {
        public const string primeiraVariavel = "R";
        public const string segundaVariavel = "L";
        public const string terceiraVariavel = "J";

        public void CalcularEquacao()
        {
            int[] valores = new int[3];
            var resultado = 0;

            Console.WriteLine("DIGITE UMA ENTRADA VÁLIDA: ");

            for (int i = 0; i < 3; i++)
            {
                string[] equacao = Console.ReadLine().ToUpper().Split('+', '=');

                if (equacao[0] == primeiraVariavel)
                {
                    valores[1] = int.Parse(equacao[1]);
                    valores[2] = int.Parse(equacao[2]);
                    resultado = valores[2] - valores[1];
                }
                else if (equacao[1] == segundaVariavel)
                {
                    valores[0] = int.Parse(equacao[0]);
                    valores[2] = int.Parse(equacao[2]);
                    resultado = valores[2] - valores[0];
                }
                else if (equacao[2] == terceiraVariavel)
                {
                    valores[0] = int.Parse(equacao[0]);
                    valores[1] = int.Parse(equacao[1]);
                    resultado = valores[0] + valores[1];
                }
                Console.WriteLine(resultado);
            }
        }
    }
}

