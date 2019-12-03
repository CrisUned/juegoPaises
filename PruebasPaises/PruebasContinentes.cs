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
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente Europa = miBaseDatosGeografica.getContiente("Europa");
            Assert.AreEqual(Europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContiente("Europa");
            
            Assert.AreNotEqual(europa.paises.Count,0);
            
        }

        public void TestEuropa_NoPaises()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContiente("Europa");

            IPais nuevazelanda = europa.getPais("NuevaZelanda");
            Assert.IsNull(nuevazelanda);
         
        }
        [TestMethod]
        public void TestEuropa_SiPais()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContiente("Europa");

            IPais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
         

        }
    }
}