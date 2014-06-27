﻿using System.Linq;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Centesimos : IClasse
    {
        public IOrdem Ordem { get; set; }

        public bool EhSingular
        {
            get { return Algarismos.Last() == 1 && Algarismos.Length == 1; }
        }

        public string Sulfixo
        {
            get { return EhSingular ? "centésimo" : "centésimos"; }
        }

        public int[] Algarismos { get { return Ordem.Algarismos; } }

        public Centesimos(IOrdem ordem)
        {
            Ordem = ordem;
        }

        public override string ToString()
        {
            return Ordem + " " + Sulfixo;
        }
    }
}