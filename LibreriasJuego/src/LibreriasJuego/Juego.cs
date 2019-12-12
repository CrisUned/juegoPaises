using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public abstract class IJuego<T> where T:IJuego<T>
    {

        private static IJuego<T> instancia;
        private static readonly object testigo = new object();

        public IBaseDatosJugadores baseDatosJugadores { get; protected set; }
        public IBaseDatosGeografica baseDatosGeografica { get; protected set; }

        public static IJuego<T> dameElJuego()
        {
            if (instancia == null)
            {
                lock (testigo)
                {
                    if (instancia == null)
                    {
                        instancia = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
            }
            
            return instancia;
        }

    

    }
}

