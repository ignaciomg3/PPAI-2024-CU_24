using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class VinoVarietal
    {
        public VinoVarietal() { }

        public int vinoId { get; set; }
        public Vino vino { get; set; }

        public int varietalId { get; set; }
        public Varietal varietal { get; set; }
    }
}
