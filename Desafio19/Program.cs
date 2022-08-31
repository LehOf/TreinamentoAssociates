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
                var NumeroDejogadas = int.Parse(Console.ReadLine());

                Musica musica = new Musica(NumeroDejogadas);
                musica.EscolhaDaMusica();
            }
            catch(EscolhaException e)
            {
                Console.WriteLine("ERRO NA ESCOLHA DA FAIXA: " + e.Message);
            }
         
        }
    }
}
