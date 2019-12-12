using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspa�a_Capital()
        {
            Juego.dameElJuego();
            BaseDatosGeografica miBaseDatosGeografica = null;
            Pais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");
             
        }
        public void TestEspa�a_Nombre()
        {
            Pais espa�a = null;
            Assert.AreEqual(espa�a.nombre, "Espa�a");

        }
        public void TestEspa�a_Continente()
        {
            Pais espa�a = null;
            Continente europa = null;
            Assert.AreEqual(espa�a.continente, europa);

        }
    }
}
