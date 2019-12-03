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
            Juego.dameElJuego();
            BaseDatosGeografica miBaseDatosGeografica = null;
            Pais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {
            Pais españa = null;
            Assert.AreEqual(españa.nombre, "España");
        }

        [TestMethod]
        public void TestEspaña_Continente()
        {
            Pais españa = null;
            Continente europa = null;
            Assert.AreEqual(españa.continente, europa);
        }
    }
}