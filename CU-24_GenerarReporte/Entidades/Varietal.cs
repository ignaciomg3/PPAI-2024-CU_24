using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Varietal
    {
        public Varietal() { }
        public int id { get; set; }
        public string descripcion { get; set; }
        public List<VinoVarietal> vinos { get; set; }

        // Constructor
        public Varietal(string descripcion)
        {
            this.descripcion = descripcion;
        }

    }
}
