using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Pregunta
    {
        public Partida partida { get; }

        public Pais pais { get; }
        public bool proponerRespuesta(string capitalSugerida);
        public int intentosRestantes { get; }
        public bool acierto { get; }
        public List<string> getRespuestasPropuestas();

    }
}