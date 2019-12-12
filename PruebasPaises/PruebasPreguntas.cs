using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPreguntas
    {
        // Prueba Nueva Pregunta
        [TestMethod]
        public void TestNuevaPregunta()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            IPartida partida = cris.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.pais); 


        }

        // Prueba Respuesta fallida
        [TestMethod]
        public void TestRespuestaFallida()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            IPartida partida = cris.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta("Ruina");
            Assert.IsFalse(resultado);

        }

        // Prueba Respuestas fallidas multiples
        [TestMethod]
        public void TestRespuestasFallidasMultiples()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            IPartida partida = cris.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();

            int intentos = pregunta.intentosRestantes;
            Assert.AreEqual(intentos, 3);

            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");

            intentos = pregunta.intentosRestantes;
            Assert.AreEqual(intentos, 0);
                          
        }

        // Prueba Respuesta correcta
        [TestMethod]
        public void TestRespuestaCorrecta()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            IPartida partida = cris.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta(pregunta.pais.capital);
            Assert.IsTrue(resultado);

        }

    }
}