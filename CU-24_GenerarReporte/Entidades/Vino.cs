using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Vino
    {
        public int Añada { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string ImagenEtiqueta { get; set; }
        public string Nombre { get; set; }
        public string NotaDeCataBodega { get; set; }
        public decimal PrecioARS { get; set; }
        public Bodega Bodega { get; set; }
        public List<Varietal> Varietales { get; set; }

        public Vino(int añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, decimal precioARS, Bodega bodega, List<Varietal> varietales)
        {
            Añada = añada;
            FechaActualizacion = fechaActualizacion;
            ImagenEtiqueta = imagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            PrecioARS = precioARS;
            Bodega = bodega;
            Varietales = varietales;
        }

        public void CalcularRanking()
        {
            // Implementación para calcular el ranking del vino
        }

        public bool CompararEtiqueta(string otraEtiqueta)
        {
            return ImagenEtiqueta.Equals(otraEtiqueta, StringComparison.OrdinalIgnoreCase);
        }

        public bool EsDeBodega(string nombreBodega)
        {
            return Bodega.Nombre.Equals(nombreBodega, StringComparison.OrdinalIgnoreCase);
        }

        public bool EsDeRegionVitivinicola(string nombreRegion)
        {
            return Bodega.Region.Nombre.Equals(nombreRegion, StringComparison.OrdinalIgnoreCase);
        }
    }

}
