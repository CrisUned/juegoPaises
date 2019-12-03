using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {
        public List<IContinente> getContinentes();
        public IContinente getContiente(string nombreContinente);
        public IPais getPais(string nombrePais);

    }
}
