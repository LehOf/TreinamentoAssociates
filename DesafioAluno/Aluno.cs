using System;
using System.Globalization;

namespace DesafioAluno
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        public double NotaMatematica { get; set; }
        public double NotaPortugues { get; set; }
        public double NotaGeografia { get; set; }

        public Aluno(string nome, string endereco, int idade, double notaMatematica, double notaPortugues, double notaGeografia)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
            NotaMatematica = notaMatematica;
            NotaPortugues = notaPortugues;
            NotaGeografia = notaGeografia;
        }

        public string ImprimirNotas()
        {
            var notas =
                $"Nome: {Nome} \nEndereco {Endereco} \nIdade: {Idade} \n" +
                 $"Nota de matemática: {NotaMatematica.ToString("F1", CultureInfo.InvariantCulture)} \n" +
                 $"Nota de português: {NotaPortugues.ToString("F1", CultureInfo.InvariantCulture)} \n" +
                 $"Nota de geografia: {NotaGeografia.ToString("F1", CultureInfo.InvariantCulture)}";

            return notas;
        }

        public string ImprimirNotas(char materia)
        {
            var entidade = "";

            if (materia == 'G' || materia == 'g')
            {
                entidade = $"Nome: {Nome} \nEndereço: {Endereco} \nIdade: {Idade} \nNota de geografia: {NotaGeografia.ToString("F1",CultureInfo.InvariantCulture)}";
            }
            else if (materia == 'M' || materia == 'm')
            {
                entidade = $"Nome: {Nome} \nEndereço: {Endereco} \nIdade: {Idade} \nNota de matematica: {NotaMatematica.ToString("F1", CultureInfo.InvariantCulture)}";
            }
            else if (materia == 'P' || materia == 'p')
            {
                entidade = $"Nome: {Nome} \nEndereço: {Endereco} \nIdade: {Idade} \nNota de portugues {NotaPortugues.ToString("F1", CultureInfo.InvariantCulture)}";
            }
            return entidade;
        }
    }
}
