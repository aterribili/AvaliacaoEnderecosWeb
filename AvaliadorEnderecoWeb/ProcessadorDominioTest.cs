using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvaliadorEnderecosWeb;

namespace AvaliadorEnderecoWeb
{
    [TestClass]
    public class ProcessadorDominioTest
    {
        [TestMethod]
        public void DeveRetornarDominioBuscape()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("buscape");

            Assert.AreEqual("http://www.buscape.com.br", dominio.AvaliaDominio().DescobreDominio());
        }

        [TestMethod]
        public void DeveRetornarDominioBondfaro()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("bondfaro");

            Assert.AreEqual("http://www.bondfaro.com.br", dominio.AvaliaDominio().DescobreDominio());
        }

        [TestMethod]
        public void DeveRetornarDominioZmoveis()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("zmoveis");

            Assert.AreEqual("http://www.zmoveis.com.cl", dominio.AvaliaDominio().DescobreDominio());
        }

        [TestMethod]
        public void DeveDescobrirParametroBuscape()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("buscape");

            Assert.AreEqual("p", dominio.AvaliaDominio().DescobreParametro());
        }

        [TestMethod]
        public void DeveDescobrirParametroBondfaro()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("bondfaro");

            Assert.AreEqual("a", dominio.AvaliaDominio().DescobreParametro());
        }

        [TestMethod]
        public void DeveDescobrirParametroZmoveis()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("zmoveis");

            Assert.AreEqual("i", dominio.AvaliaDominio().DescobreParametro());
        }

        [TestMethod]
        public void DeveDescobrirCookieBuscape()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("buscape");

            Assert.AreEqual("bp", dominio.AvaliaDominio().DescobreCookie());
        }

        [TestMethod]
        public void DeveDescobrirCookieBondfaro()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("bondfaro");

            Assert.AreEqual("ba", dominio.AvaliaDominio().DescobreCookie());
        }

        [TestMethod]
        public void DeveDescobrirCookieZmoveis()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("zmoveis");

            Assert.AreEqual("zi", dominio.AvaliaDominio().DescobreCookie());
        }
    }
}
