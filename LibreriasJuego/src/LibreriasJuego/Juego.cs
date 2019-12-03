using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Juego
    {
        private Juego()
        {
            baseDatosJugadores = null;
        }

        private static Juego elJuego;

        public static Juego dameElJuego()
        {
            if (elJuego == null)
            {
                elJuego = new Juego();
            }
            return elJuego;
        }

        public BaseDatosJugadores baseDatosJugadores { get; }
        public BaseDatosGeografica baseDatosGeografica { get; }


    }
}

