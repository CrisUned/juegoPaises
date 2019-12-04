using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src
{
    class Dummy
    {
        public static void Main() 
        {
            pintarEvaluacion(cuadrado ,5);
            pintarEvaluacion(tercio, 5);

            // utilizando las funciones lambda seria así:
            pintarEvaluacion((numero) => numero * numero, 5); //funcion cuadrado
            pintarEvaluacion((j) => j / 3, 5); //esto seria lo mismo que llamar a la funcion TERCIO
           
        }

        public static int cuadrado(int x) 
        {
            return x * x;
        }

        public static int tercio(int j)
        {
            return j/3;
        }
        public static void pintarEvaluacion(Func<int,int> funcion, int x)
        {
            int resultado = funcion(x);
            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
