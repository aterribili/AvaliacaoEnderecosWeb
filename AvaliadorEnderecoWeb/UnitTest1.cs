using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvaliadorEnderecosWeb;

namespace AvaliadorEnderecoWeb
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveRetornarBuscapeCasoSiteSejaBuscape()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("buscape");

            Assert.AreEqual("http://www.buscape.com.br", dominio.DescobreDominio());
        }

        [TestMethod]
        public void DeveRetornarBondfaroCasoSiteSejaBondfaro()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("bondfaro");

            Assert.AreEqual("http://www.bondfaro.com.br", dominio.DescobreDominio());
        }

        [TestMethod]
        public void DeveRetornarZmoveisCasoSiteSejaZmoveis()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("zmoveis");

            Assert.AreEqual("http://www.zmoveis.com.cl", dominio.DescobreDominio());
        }

        [TestMethod]
        public void DeveDescobrirNomeParametroBuscape()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("buscape");

            Assert.AreEqual("p", dominio.DescobreParametro());
        }

        [TestMethod]
        public void DeveDescobrirNomeParametroBondfaro()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("bondfaro");

            Assert.AreEqual("a", dominio.DescobreParametro());
        }

        [TestMethod]
        public void DeveDescobrirNomeParametroZMoveis()
        {
            ProcessadorDominio dominio = new ProcessadorDominio("zmoveis");

            Assert.AreEqual("i", dominio.DescobreParametro());
        }
    }
}
