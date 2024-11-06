using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Datos
{
    public class GestorBD
    {
        private string cadenaConexion { get; set; }

        public GestorBD(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }



    }
}
