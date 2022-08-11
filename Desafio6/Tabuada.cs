using System;


namespace Desafio6
{
    class Tabuada
    {
        public int N { get; set; }

        public string Tabuada(int n)
        {
            string RetornoTabuada;
            for (int i=1; i<=10; i++)
            { 
                double resultado = i * n;
                return RetornoTabuada = ($"{i} X {n} = {resultado}");  
            }
           
        } 
    }
}
