using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Core;
using System;

namespace EscritaPorExtenso.Metragem
{
    internal class MetroQuadrado
    {
        Classe _parteInteira;
        Classe _parteDecimal;
        private string _pluralidadeInteira;
        private string _pluralidadeDecimal;

        public MetroQuadrado(decimal valor)
        {
            var numeroDaParteInteira = (long)Math.Truncate(valor);

            if (numeroDaParteInteira > 0)
            {
                _parteInteira = ConversorDeNumeroParaClasses.Converter(numeroDaParteInteira);
                _pluralidadeInteira = ObterPluralidadeDaParteInteira(numeroDaParteInteira);
            }

            var valorStr = valor.ToString();
            var indexOfDecimal = valorStr.IndexOf(',');
            if (indexOfDecimal == 0)
                indexOfDecimal = valorStr.IndexOf('.');

            var parteDecimal = Convert.ToDecimal(valorStr.Substring(indexOfDecimal + 1));

            var numeroDaParteDecimal = (long)parteDecimal;

            if (numeroDaParteDecimal > 0)
            {
                _parteDecimal = ConversorDeNumeroParaClasses.Converter(numeroDaParteDecimal);
                _pluralidadeDecimal = ObterPluralidadeDaParteDecimal(numeroDaParteDecimal);
            }
        }

        private static string ObterPluralidadeDaParteInteira(long parteInteira)
        {
            return parteInteira > 1 ? "metros quadrados" : "metro quadrado";
        }

        private static string ObterPluralidadeDaParteDecimal(long numeroDaParteDecimal)
        {
            return numeroDaParteDecimal > 1 ? "decímetros quadrados" : "decímetro quadrado";
        }

        public override string ToString()
        {
            string parteInteira = string.Format("{0} {1}", _parteInteira, _pluralidadeInteira);
            string parteDecimal = string.Format("{0} {1}", _parteDecimal, _pluralidadeDecimal);

            if (_parteDecimal != null && _parteInteira != null)
                return string.Format("{0} e {1}", parteInteira, parteDecimal);

            if (_parteDecimal != null)
                return parteDecimal;

            if (_parteInteira != null)
                return parteInteira;

            return "zero metro quadrado";
        }
    }
}

