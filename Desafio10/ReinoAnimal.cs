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

        public string EspecieDosVertebrados()
        {
            if (_PrimeiraClassificacao == "vertebrado" && _SegundaClassificacao == "ave" && _TerceiraClassificacao == "carnivoro")
            {
                _ClassificacaoResultante = "aguia";
            }
            else if (_PrimeiraClassificacao == "vertebrado" && _SegundaClassificacao == "ave" && _TerceiraClassificacao == "onivoro")
            {
                _ClassificacaoResultante = "pomba";
            }
            else if (_PrimeiraClassificacao == "vertebrado" && _SegundaClassificacao == "mamifero" && _TerceiraClassificacao == "onivoro")
            {
                _ClassificacaoResultante = "homem";
            }
            else if (_PrimeiraClassificacao == "vertebrado" && _SegundaClassificacao == "mamifero" && _TerceiraClassificacao == "herbivoro")
            {
                _ClassificacaoResultante = "vaca";
            }

            return _ClassificacaoResultante;

        }
        public string EspeciesDosInvertebrados()
        {
            if (_PrimeiraClassificacao == "invertebrado" && _SegundaClassificacao == "inseto" && _TerceiraClassificacao == "hematofago")
            {
                _ClassificacaoResultante = "pulga";
            }
            else if (_PrimeiraClassificacao == "invertebrado" && _SegundaClassificacao == "inseto" && _TerceiraClassificacao == "herbivaro")
            {
                _ClassificacaoResultante = "lagarta";
            }
            else if (_PrimeiraClassificacao == "invertebrado" && _SegundaClassificacao == "anelideo" && _TerceiraClassificacao == "hematofago")
            {
                _ClassificacaoResultante = "sanguessuga";
            }
            else if (_PrimeiraClassificacao == "invertebrado" && _SegundaClassificacao == "anelideo" && _TerceiraClassificacao == "onivoro")
            {
                _ClassificacaoResultante = "minhoca";
            }

            return _ClassificacaoResultante;
        }
    }
}
