using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Juego
    {
        private Juego()
        {
            baseDatosJugadores = new BaseDatosJugadoresRAM();
            baseDatosGeografica = new BaseDatosGeografica();
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

        public IBaseDatosJugadores baseDatosJugadores { get; }
        public IBaseDatosGeografica baseDatosGeografica { get; }


    }
}

