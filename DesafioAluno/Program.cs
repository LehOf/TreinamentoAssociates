using System;
using System.Globalization;

namespace DesafioAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NOME: ");
            var Nome = Console.ReadLine();
            Console.Write("ENDEREÇO: ");
            var Endereco = Console.ReadLine();
            Console.Write("IDADE: ");
            var Idade = int.Parse(Console.ReadLine());
            Console.Write("NOTA DE MATEMÁTICA: ");
            var NotaMatematica = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA DE PORTUGUÊS: ");
            var NotaPortugues = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA DE GEOGRAFIA: ");
            var NotaGeografia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.Write("ESCOLHA UMA OPÇÃO (M-MATEMATICA / P-PORTUGUES/ G-GEOGRAFIA): ");
            var escolha = char.Parse(Console.ReadLine());
            Console.WriteLine("");

            Aluno aluno = new Aluno(Nome, Endereco, Idade, NotaMatematica, NotaPortugues, NotaGeografia);

            Console.WriteLine(aluno.ImprimirNotas());
            Console.WriteLine("");
            Console.WriteLine(aluno.ImprimirNotas(escolha)); 
        }
    }
}




