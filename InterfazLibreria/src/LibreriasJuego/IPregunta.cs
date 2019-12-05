using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IPregunta
    {
        public IPartida partida { get; }

        public IPais pais { get; }
        public bool proponerRespuesta(string capitalSugerida);
        public int intentosRestantes { get; }
        public bool acierto { get; }
        public List<string> respuestasPropuestas { get; }

    }
}