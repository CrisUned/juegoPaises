using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    interface BaseDatosGeografica
    {
        public List<Continente> getContinentes();
        public Continente getContiente(string nombreContinente);
        public Pais getPais(string nombrePais);

    }
}
