using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class BaseDatosJugadoresRAM: IBaseDatosJugadores
    {
        public BaseDatosJugadoresRAM() {
            this.misJugadores = new Dictionary<string, IJugador>();
        }

        private Dictionary<string, IJugador> misJugadores { get; }

        public IJugador nuevoJugador(string nombreJugador)
        {
            IJugador j = new Jugador(nombreJugador);
            this.misJugadores.Add(nombreJugador, j);
            return j;
        }

        public IList<IJugador> jugadores { get => new List<IJugador>(this.misJugadores.Values).AsReadOnly(); }
        

        public IJugador getJugador(string nombreJugador)
        {
            return this.misJugadores[nombreJugador];
        }

        public IJugador getOrCreateJugador(string nombreJugador)
        {
            if (this.misJugadores.ContainsKey(nombreJugador))
                return getJugador(nombreJugador);
            return nuevoJugador(nombreJugador);
        }

    }
}
