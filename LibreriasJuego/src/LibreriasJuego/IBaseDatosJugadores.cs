using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosJugadores
    {
        public IJugador nuevoJugador(string nombreJugador);
        public List<IJugador> getJugadores();
        public IJugador getJugador(string nombreJugador);
        public IJugador getOrCreateJugador(string nombreJugador);
    }
}
