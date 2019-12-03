using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropa_Nombre()
        {
            BaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente Europa = miBaseDatosGeografica.getContiente("Europa");
            Assert.AreEqual(Europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            BaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContiente("Europa");
            
            Assert.AreNotEqual(europa.paises.Count,0);
            
        }

        public void TestEuropa_NoPaises()
        {
            BaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContiente("Europa");

            Pais nuevazelanda = europa.getPais("NuevaZelanda");
            Assert.IsNull(nuevazelanda);
         
        }
        [TestMethod]
        public void TestEuropa_SiPais()
        {
            BaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContiente("Europa");

            Pais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
         

        }
    }
}