using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Provincia
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<RegionVitivinicola> regiones { get; set; }

        public int paisId { get; set; }
        public Pais pais { get; set; }

        // Constructor
        public Provincia(string nombre, List<RegionVitivinicola> regionesVitivinicola)
        {
            this.nombre = nombre;
            this.regiones = regionesVitivinicola;
        }

        public Provincia() { }

        public string obtenerPais()
        {
            return pais.nombre;
        }
    }
}
