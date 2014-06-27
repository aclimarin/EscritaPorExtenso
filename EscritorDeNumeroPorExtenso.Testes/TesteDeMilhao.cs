using EscritorDeNumeroPorExtenso.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestClass]
    public class TesteDeMilhao
    {
        [TestMethod]
        public void DeveGerarNumeroUmMilhao()
        {
            Assert.AreEqual("um milh�o", new Milhao(new Unidade(1)).ToString());
        }

        [TestMethod]
        public void DeveGerarNumeroDezMilh�es()
        {
            Assert.AreEqual("dez milh�es", new Milhao(new Dezena(1)).ToString());
        }

        [TestMethod]
        public void DeveGerarNumeroUmMilhaoECemMil()
        {
            Assert.AreEqual("um milh�o e cem mil", new Milhao(new Unidade(1), new Milhar(new Centena(1))).ToString());
        }

        [TestMethod]
        public void DeveGerarNumeroUmMilhaoECemMilEUm()
        {
            Assert.AreEqual("um milh�o e cem mil e um", new Milhao(new Unidade(1), new Milhar(new Centena(1), new PrimeiraClasse(new Unidade(1)))).ToString());
        }
    }
}