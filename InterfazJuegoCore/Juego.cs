using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Juego:IJuego<Juego>
    {
        private Juego()
        {
            baseDatosJugadores = new BaseDatosJugadoresRAM();
            baseDatosGeografica = new BaseDatosGeografica();
        }
         
     }

        
}

