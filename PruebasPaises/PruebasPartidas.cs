﻿using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPartidas
    {
        // Prueba Recuperar Lista Partidas
        [TestMethod]
        public void TestRecuperarListaPartidas1()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Assert.IsNotNull(cris.historicoPartidas);  // me devuelve una lista de partidas aunque esté vacía

        }

        // Prueba Nueva Partida
        [TestMethod]
        public void TestNuevaPartida()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");
            Continente europa = Juego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            Partida partida = cris.nuevaPartida(europa);
            Assert.IsNotNull(partida);  

        }


        // Prueba Nueva Partida 2 para saber si las mete en la lista de partidas historicas
        [TestMethod]
        public void TestNuevaPartida2()
        {
            BaseDatosJugadores miBaseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador cris = miBaseDatosJugadores.getOrCreateJugador("Cris");

            int cuantasllevaba = cris.historicoPartidas.Count;

            Continente europa = Juego.dameElJuego().baseDatosGeografica.getContiente("Europa");
            Partida partida = cris.nuevaPartida(europa);

            int cuantaslleva = cris.historicoPartidas.Count;

            Assert.AreEqual(cuantasllevaba + 1, cuantaslleva);

            // le pido la ultima partida de la lista
            Assert.AreEqual(cris.historicoPartidas[cris.historicoPartidas.Count - 1], partida);


        }

    }
}