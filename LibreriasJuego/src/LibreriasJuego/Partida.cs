using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface Partida
    {
        public Jugador jugador { get; }
        public Continente GetContinente();
        public List<Pregunta> getHistoricoPreguntas();
        public Pregunta nuevaPregunta();
    }
}
