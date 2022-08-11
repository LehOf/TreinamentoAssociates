using System;


namespace Desafio6
{
    class Tabuada
    {
        public int N { get; set; }

        public void CalculoTabuada(int N)
        {

            for (int i=1; i<=10; i++)
            { 
                int resultado = i * N;
                Console.WriteLine(($"{i} X {N} = {resultado}"));  
            }
           
        } 
    }
}
