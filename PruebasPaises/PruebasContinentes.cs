using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContiente("Europa");
            
            Assert.AreNotEqual(europa.paises.Count,0);
            
        }
        [TestMethod]
        public void TestEuropa_NoPaises()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContiente("Europa");

            // IPais nuevazelanda = europa.getPais("NuevaZelanda");
            //System.Action funcionAlaQueTienesQueLlamar = recuperarNuevaZelanda;
            
            Assert.ThrowsException<KeyNotFoundException>(
                () =>europa.getPais("NuevaZelanda"));
         
        }
        
        [TestMethod]
        public void TestEuropa_SiPais()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContiente("Europa");

            IPais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
         

        }
    }
}