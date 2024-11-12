using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Pais
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Provincia> provincias { get; set; }

        // Constructor
        public Pais(string nombre, List<Provincia> provincias)
        {
            this.nombre = nombre;
            this.provincias = provincias;
        }

        public Pais() { }

    }
}
