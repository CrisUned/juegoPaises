using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugador
    {
        // prueba nombre
        [TestMethod]
        public void TestJugador_Nombre()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getJugador("Cris");
            Assert.AreEqual(cris.nombre, "Cris");
        }

        // Prueba Alta
        [TestMethod]
        public void TestJugadores_Alta()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.nuevoJugador("Cris");
            Assert.IsNotNull(cris);

        }

        //prueba Recuperar jugador
        [TestMethod]
        public void TestJugador_Recupera()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getJugador("Cris");
            Assert.IsNotNull(cris);
         
        }

        // Prueba Alta y recupera
        [TestMethod]
        public void TestJugadores_AltayRecupera()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Assert.AreEqual(cris.nombre, "Cris");

        }
    }
}