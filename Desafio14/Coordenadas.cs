using System;

namespace Desafio14
{
    class Coordenadas
    {
        public void ValorDoQuadrante()
        {
            var quadrante = "";

            while (true)
            {
                Console.Write("Digite o valor da coordenada X e coordenada Y: ");
                string[] coordenadas = Console.ReadLine().Split(' ');

                var coordenadaX = int.Parse(coordenadas[0]);
                var coordenadaY = int.Parse(coordenadas[1]);

                if (coordenadaX != 0 && coordenadaY != 0)
                {
                    if (coordenadaX >= 0 && coordenadaY >= 0)
                    {
                        quadrante = "primeiro";
                    }
                    else if (coordenadaX <= 0 && coordenadaY >= 0)
                    {
                        quadrante = "segundo";
                    }
                    else if (coordenadaX <= 0 && coordenadaY <= 0)
                    {
                        quadrante = "terceiro";
                    }
                    else if (coordenadaX >= 0 && coordenadaY <= 0)
                    {
                        quadrante = "quarto";
                    }
                }
                else
                {
                    break;
                }
                Console.WriteLine(quadrante);
            }
        }
    }
}


