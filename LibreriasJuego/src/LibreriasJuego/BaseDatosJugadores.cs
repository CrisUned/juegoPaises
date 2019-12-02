using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    interface BaseDatosJugadores
    {
        public Jugador nuevoJugador(string nombreJugador);
        public List<Jugador> getJugadores();
        public Jugador getJugador(string nombreJugador);
        public Jugador getOrCreateJugador(string nombreJugador);
    }
}
