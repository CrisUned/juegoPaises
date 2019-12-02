using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    interface Jugador
    {
        public string nombre { get; } // pongo get porque lo puedo ver pero no cambiar
        public List<Partida> historicoPartidas { get; } //list es un tipo de variable de c#, <> lo que va dentro de la lista
        public Partida nuevaPartida(Continente continenteElegido);
    }
}
