using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Pais
    {
        public string nombre { get; set; }
        public List<Provincia> provincias { get; set; }

        // Constructor
        public Pais(string nombre, List<Provincia> provincias)
        {
            this.nombre = nombre;
            this.provincias = provincias;
        }

    }
}
