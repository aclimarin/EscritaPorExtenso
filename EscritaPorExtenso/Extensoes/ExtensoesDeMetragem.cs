using System;

namespace EscritaPorExtenso.Metragem
{
    public static class ExtensoesDeMetragem
    {
        public static string PorExtensoDeMetragem(this int valor)
        {
            return new MetroQuadrado(valor).ToString();
        }

        public static string PorExtensoDeMetragem(this long valor)
        {
            return new MetroQuadrado(valor).ToString();
        }

        public static string PorExtensoDeMetragem(this double valor)
        {
            return new MetroQuadrado(Convert.ToDecimal(valor)).ToString();
        }

        public static string PorExtensoDeMetragem(this float valor)
        {
            return new MetroQuadrado(Convert.ToDecimal(valor)).ToString();
        }

        public static string PorExtensoDeMetragem(this decimal valor)
        {
            return new MetroQuadrado(valor).ToString();
        }
    }
}