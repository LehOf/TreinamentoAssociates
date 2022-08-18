using System;

namespace Desafio10
{
    class ReinoAnimal
    {
        private string _PrimeiraClassificacao { get; set; }
        private string _SegundaClassificacao { get; set; }
        private string _TerceiraClassificacao { get; set; }
        private string _ClassificacaoResultante { get; set; }

        public ReinoAnimal(string _primeiraClassificacao, string _segundaClassificacao, string _terceiraClassificacao)
        {
            _PrimeiraClassificacao = _primeiraClassificacao;
            _SegundaClassificacao = _segundaClassificacao;
            _TerceiraClassificacao = _terceiraClassificacao;
        }

        public string EspecieVertebradosInvertebrados(string _primeiraEspecie)
        {
            if (_primeiraEspecie == "vertebrado")
            {
                if (_SegundaClassificacao == "ave")
                {
                    if (_TerceiraClassificacao == "carnivoro")
                    {
                        _ClassificacaoResultante = "aguia";
                    }
                    else if (_TerceiraClassificacao == "onivoro")
                    {
                        _ClassificacaoResultante = "homem";
                    }
                }
                else if (_SegundaClassificacao == "mamifero")
                {
                    if (_TerceiraClassificacao == "onivoro")
                    {
                        _ClassificacaoResultante = "homem";
                    }
                    else if (_TerceiraClassificacao == "herbivaro")
                    {
                        _ClassificacaoResultante = "vaca";
                    }
                }
            }
            else if (_primeiraEspecie == "invertebrado")
            {
                if (_SegundaClassificacao == "inseto")
                {
                    if (_TerceiraClassificacao == "hematofago")
                    {
                        _ClassificacaoResultante = "pulga";
                    }
                    else if (_TerceiraClassificacao == "herbivaro")
                    {
                        _ClassificacaoResultante = "lagarta";
                    }
                }
                else if (_SegundaClassificacao == "anelideo")
                {
                    if (_TerceiraClassificacao == "hematofago")
                    {
                        _ClassificacaoResultante = "sanguessuga";
                    }
                    else if (_TerceiraClassificacao == "onivoro")
                    {
                        _ClassificacaoResultante = "minhoca";
                    }
                }
            }
            return _ClassificacaoResultante;
        }

        public override string ToString()
        {
            return ($"{EspecieVertebradosInvertebrados(_PrimeiraClassificacao)}");
        }
    }

   
}