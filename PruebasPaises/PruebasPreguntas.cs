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
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Continente europa = Juego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            Partida partida = cris.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();
            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.pais); 


        }

        // Prueba Respuesta fallida
        [TestMethod]
        public void TestRespuestaFallida()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Continente europa = Juego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            Partida partida = cris.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta("Ruina");
            Assert.IsFalse(resultado);

        }

        // Prueba Respuestas fallidas multiples
        [TestMethod]
        public void TestRespuestasFallidasMultiples()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Continente europa = Juego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            Partida partida = cris.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();

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
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Continente europa = Juego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            Partida partida = cris.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta(pregunta.pais.capital);
            Assert.IsTrue(resultado);

        }

    }
}