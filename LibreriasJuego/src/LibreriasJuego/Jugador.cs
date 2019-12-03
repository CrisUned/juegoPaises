using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Jugador:IJugador
    {
        internal Jugador(string nombre)
        {
            this.nombre = nombre;
            this.historicoPartidas = new List<IPartida>();
        }
        public string nombre { get; } // pongo get porque lo puedo ver pero no cambiar
        public List<IPartida> historicoPartidas { get; } //list es un tipo de variable de c#, <> lo que va dentro de la lista
        public IPartida nuevaPartida(IContinente continenteElegido)
        {
            Partida p = new Partida(this, continenteElegido);
            this.historicoPartidas.Add(p);
            return p;
        }
    }
}
