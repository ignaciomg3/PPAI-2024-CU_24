using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Bodega
    {
        public string nombre { get; set; }
        public RegionVitivinicola region { get; set; }
        

        // Constructor
        public Bodega(string nombre, RegionVitivinicola region)
        {
            this.nombre = nombre;
            this.region = region;
        }

        public string obtenerRegion()
        {
            return region.nombre;
            
        }

        public string obtenerPais()
        {
            return region.obtenerPais();
           
        }
    }
}
