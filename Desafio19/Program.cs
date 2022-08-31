using System;

namespace Desafio19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("ENTRE COM O NÚMERO DE MUSICAS A SEREM TOCADAS: ");
                var numeroDejogadas = int.Parse(Console.ReadLine());
                var contador = 0;

                var musica = new Musica(numeroDejogadas);

                do
                {
                    Console.WriteLine(musica.MusicasMaisTocadas());
                    contador++;

                } while (contador < numeroDejogadas);

            }
            catch(EscolhaException e)
            {
                Console.WriteLine("ERRO NA ESCOLHA DA FAIXA: " + e.Message);
            }          
        }
    }
}
