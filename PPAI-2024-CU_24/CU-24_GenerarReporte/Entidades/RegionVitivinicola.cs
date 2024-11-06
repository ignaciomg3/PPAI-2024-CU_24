using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class RegionVitivinicola
    {
        public string nombre { get; set; }
        public Provincia provincia { get; set; }

        // Constructor
        public RegionVitivinicola(string nombre)
        {
            this.nombre = nombre;
        }

        public string obtenerPais()
        {
            return provincia.obtenerPais();
        }
    }
}
