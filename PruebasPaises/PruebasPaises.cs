using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspaña_Capital()
        {
            BaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {
            BaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.nombre, "España");
        }

        [TestMethod]
        public void TestEspaña_Continente()
        {
            BaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais españa = miBaseDatosGeografica.getPais("España");
            Continente europa = miBaseDatosGeografica.getContiente("Europa");
            Assert.AreEqual(españa.continente, europa);
            
        }
    }
}