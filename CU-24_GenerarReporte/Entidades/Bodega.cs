using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Bodega
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int regionVitivinicolaId { get; set; }
        public RegionVitivinicola region { get; set; }
        public List<Vino> vinos { get; set; }
        

        // Constructor
        public Bodega(string nombre, RegionVitivinicola region)
        {
            this.nombre = nombre;
            this.region = region;
        }

        public Bodega() { }

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
