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

        private List<Reseña> Reseñas { get; set; } 

        public double promedioPuntajePromedioSommelier { get; set; }

        public Vino(int añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, decimal precioARS, Bodega bodega, List<Varietal> varietales,List<Reseña> reseñas)
        {
            Añada = añada;
            FechaActualizacion = fechaActualizacion;
            ImagenEtiqueta = imagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            PrecioARS = precioARS;
            Bodega = bodega;
            Varietales = varietales;
            Reseñas = reseñas;
            promedioPuntajePromedioSommelier = 0;
        }

        public Vino()
        {
            // Inicializa las propiedades si es necesario
            Varietales = new List<Varietal>();
            Reseñas = new List<Reseña>();
        }
        public void CalcularRanking()
        {
            // Implementación para calcular el ranking del vino
        }

        public bool CompararEtiqueta(string otraEtiqueta)
        {
            return ImagenEtiqueta.Equals(otraEtiqueta, StringComparison.OrdinalIgnoreCase);
        }

        public bool buscarInfoBodega()
        {
            return Bodega.Nombre.Equals(Nombre);
        }

        public bool EsDeRegionVitivinicola(string nombreRegion)
        {
            return Bodega.Region.Nombre.Equals(nombreRegion, StringComparison.OrdinalIgnoreCase);
        }

        public Vino tenesReseñasDeTipoEnPeriodo(Vino vino,DateTime FechaDesde, DateTime FechaHasta)
        {
            Vino vinoEvaluado = new Vino();
            foreach(Reseña rese in vino.Reseñas)
            {
                vinoEvaluado = vino;
                bool cumplePeriodo = rese.SosDePeriodo(FechaDesde, FechaHasta);
                bool cumpleSommelier = rese.SosDeSommelier();
                if (cumplePeriodo && cumpleSommelier)
                {
                    return vinoEvaluado;
                }
            }
            return null;
        }

        public List<string> buscarDescripcionDeVarietal()
        {
            List <string> listaDescripcionVarietales = new List <string>();
            foreach(Varietal var in Varietales)
            {
                string descripcionVar = var.Descripcion;
                listaDescripcionVarietales.Add(descripcionVar);
            }
            return listaDescripcionVarietales;
        }

        public void CalcularPuntajeDeSommelierEnPeriodo(DateTime desde,DateTime hasta )
        {
            int puntajeTotal = 0;
            int contador  = 0;

            foreach(Reseña r in this.Reseñas)
            {
                if (r.SosDeSommelier() && desde <= r.FechaReseña && r.FechaReseña <= hasta)
                {
                    puntajeTotal += r.Puntaje;
                    contador++;
                }
            }

            this.promedioPuntajePromedioSommelier = CalcularPuntajePromedio(puntajeTotal, contador);
              
        }

        public int CalcularPuntajePromedio(int puntajeTotal, int contador )
        {
            return puntajeTotal/contador;
        }
    }

}
