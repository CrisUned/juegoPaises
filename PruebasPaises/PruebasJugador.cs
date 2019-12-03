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
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getJugador("Cris");
            Assert.AreEqual(cris.nombre, "Cris");
        }

        // Prueba Alta
        [TestMethod]
        public void TestJugadores_Alta()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.nuevoJugador("Cris");
            Assert.IsNotNull(cris);

        }

        //prueba Recuperar jugador
        [TestMethod]
        public void TestJugador_Recupera()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getJugador("Cris");
            Assert.IsNotNull(cris);
         
        }

        // Prueba Alta y recupera
        [TestMethod]
        public void TestJugadores_AltayRecupera()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Assert.AreEqual(cris.nombre, "Cris");

        }
    }
}