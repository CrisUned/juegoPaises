using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class BaseDatosGeografica: IBaseDatosGeografica
    {
        internal BaseDatosGeografica()
        {
            this.paises = new Dictionary<string, IPais>();
            this.continentes = new Dictionary<string, IContinente>();
        }

        private Dictionary<string, IPais> paises;
        private Dictionary<string, IContinente> continentes;
                
        public IContinente getContiente(string nombreContinente)
        {
            return this.continentes[nombreContinente];
        }
        public IPais getPais(string nombrePais)
        {
            return this.paises[nombrePais];
        }
        public IList<IContinente> getContinentes()
        {
            return new List<IContinente>(this.continentes.Values).AsReadOnly();
        }
    }
}
