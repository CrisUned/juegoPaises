using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Pregunta
    {
        public Partida GetPartida();
        public Pais GetPais();
        public bool proponerRespuesta(string capitalSugerida);
        public int intentosRestantes { get; }
        public bool acierto { get; }
        public List<string> getRespuestasPropuestas();

    }
}