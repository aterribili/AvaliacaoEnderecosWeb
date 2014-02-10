using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvaliadorEnderecosWeb;

namespace AvaliadorEnderecoWeb
{
    [TestClass]
    public class ProcessadorSiteTest
    {
        [TestMethod]
        public void DeveRetornarDominioBuscape()
        {
            ProcessadorSite dominio = new ProcessadorSite("buscape");

            Assert.AreEqual("http://www.buscape.com.br", dominio.AvaliaDominio().Dominio());
        }

        [TestMethod]
        public void DeveRetornarDominioBondfaro()
        {
            ProcessadorSite dominio = new ProcessadorSite("bondfaro");

            Assert.AreEqual("http://www.bondfaro.com.br", dominio.AvaliaDominio().Dominio());
        }

        [TestMethod]
        public void DeveRetornarDominioZmoveis()
        {
            ProcessadorSite dominio = new ProcessadorSite("zmoveis");

            Assert.AreEqual("http://www.zmoveis.com.cl", dominio.AvaliaDominio().Dominio());
        }

        [TestMethod]
        public void DeveRetornarParametroBuscape()
        {
            ProcessadorSite dominio = new ProcessadorSite("buscape");

            Assert.AreEqual("p", dominio.AvaliaDominio().Parametro());
        }

        [TestMethod]
        public void DeveRetornarParametroBondfaro()
        {
            ProcessadorSite dominio = new ProcessadorSite("bondfaro");

            Assert.AreEqual("a", dominio.AvaliaDominio().Parametro());
        }

        [TestMethod]
        public void DeveRetornarParametroZmoveis()
        {
            ProcessadorSite dominio = new ProcessadorSite("zmoveis");

            Assert.AreEqual("i", dominio.AvaliaDominio().Parametro());
        }

        [TestMethod]
        public void DeveRetornarCookieBuscape()
        {
            ProcessadorSite dominio = new ProcessadorSite("buscape");

            Assert.AreEqual("bp", dominio.AvaliaDominio().Cookie());
        }

        [TestMethod]
        public void DeveRetornarCookieBondfaro()
        {
            ProcessadorSite dominio = new ProcessadorSite("bondfaro");

            Assert.AreEqual("ba", dominio.AvaliaDominio().Cookie());
        }

        [TestMethod]
        public void DeveRetornarCookieZmoveis()
        {
            ProcessadorSite dominio = new ProcessadorSite("zmoveis");

            Assert.AreEqual("zi", dominio.AvaliaDominio().Cookie());
        }
    }
}
