using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class RegionVitivinicola
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public int provinciaId { get; set; }
        public Provincia provincia { get; set; }
        public List<Bodega> bodegas { get; set; }

        // Constructor
        public RegionVitivinicola(string nombre)
        {
            this.nombre = nombre;
        }

        public RegionVitivinicola() { }

        public string obtenerPais()
        {
            return provincia.obtenerPais();
        }
    }
}
