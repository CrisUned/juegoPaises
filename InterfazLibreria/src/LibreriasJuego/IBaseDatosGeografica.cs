using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {
        public IList<IContinente> getContinentes();
        public IContinente getContiente(string nombreContinente);
        public IPais getPais(string nombrePais);

    }
}
