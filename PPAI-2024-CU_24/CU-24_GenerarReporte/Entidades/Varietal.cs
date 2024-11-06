using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Varietal
    {
        public string descripcion { get; set; }

        // Constructor
        public Varietal(string descripcion)
        {
            this.descripcion = descripcion;
        }

    }
}
