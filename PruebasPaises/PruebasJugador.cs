using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugador
    {
        // Prueba Alta
        [TestMethod]
        public void TestJugadores_Alta()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.nuevoJugador("Cris3");
            Assert.IsNotNull(cris);

        }
        // prueba nombre
        [TestMethod]
        public void TestJugador_Nombre()
        {
            IBaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador criso = miBaseDatosJugadores.nuevoJugador("Cris");

            IJugador cris = miBaseDatosJugadores.getJugador("Cris");
            Assert.AreEqual(cris.nombre, "Cris");
        }

        

        //prueba Recuperar jugador
        [TestMethod]
        public void TestJugador_Recupera()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador criso = miBaseDatosJugadores.nuevoJugador("Cris2");

            IJugador cris = miBaseDatosJugadores.getJugador("Cris2");
            Assert.IsNotNull(cris);
         
        }

        // Prueba Alta y recupera
        [TestMethod]
        public void TestJugadores_AltayRecupera()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Assert.AreEqual(cris.nombre, "Cris");

        }
    }
}