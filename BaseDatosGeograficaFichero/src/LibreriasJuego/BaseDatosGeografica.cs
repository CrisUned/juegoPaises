using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace LibreriasJuego
{
    public class BaseDatosGeografica: IBaseDatosGeografica
    {
        public BaseDatosGeografica()
        {
            this.paises = new Dictionary<string, IPais>();
            this.continentes = new Dictionary<string, IContinente>();
            popularBaseDatos();
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

        private void popularBaseDatos()
        {
            // voy a crear una lista que tenga los nombres de los continentes para luego trabajar con cada fichero
            List<string> nombresContinentes = new List<string>();
            nombresContinentes.Add("Africa");
            nombresContinentes.Add("America");
            nombresContinentes.Add("Asia");
            nombresContinentes.Add("Europa");
            nombresContinentes.Add("Oceania");

          
            foreach (string nombre in nombresContinentes)
            {
                // crear el continente
                Continente c = new Continente(nombre);
                this.continentes.Add(nombre, c);

                // leer fichero por continente
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                                            , @"continentes\" + nombre + ".txt");
                
                string[] lineas = File.ReadAllLines(path);

                // crear los paises
                foreach (string linea in lineas)
                {
                    //recupero el pais
                    IPais p = procesarLineaPais(linea, c);

                    // almaceno el pais en mis BD
                    if (!this.paises.ContainsKey(p.nombre))
                        this.paises.Add(p.nombre, p);  // almacenado en el diccionario de paises
                    c.asignarPais(p);  // almacenado en el diccionario de continentes

                }
            }
        }

        private IPais procesarLineaPais(string linea, IContinente continente)
        {
            // Angola: Luanda - Kwanza
            string[] partes = linea.Split(":");
            String nombre = partes[0].Trim();
            partes = partes[1].Split("-");
            String capital = partes[0].Trim();
            IPais p = new Pais(continente, nombre, capital);
            return p;
        }
    }
}
