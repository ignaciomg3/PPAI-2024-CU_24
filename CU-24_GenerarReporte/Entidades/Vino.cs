using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Vino
    {
        public int id { get; set; }    
        public string nombre { get; set; }
        public decimal precioARS { get; set; }
        public int bodegaId { get; set; }
        public Bodega bodega { get; set; }
        public List<VinoVarietal> varietales { get; set; } = new List<VinoVarietal>();
        public List<Reseña> reseñas{ get; set; }

        public Vino(string nombre, decimal precioARS, Bodega bodega, List<VinoVarietal> varietales,List<Reseña> reseñas)
        {
            this.nombre = nombre;
            this.precioARS = precioARS;
            this.bodega = bodega;
            this.varietales = varietales;
            this.reseñas = reseñas;
        }

        public Vino() { }

        public bool tenesReseñasDeTipoEnPeriodo(DateTime FechaDesde, DateTime FechaHasta)
        {
            foreach(Reseña rese in reseñas)
            {
                bool cumplePeriodo = rese.sosDePeriodo(FechaDesde, FechaHasta);
                bool cumpleSommelier = rese.sosDeSommelier();
                if (cumplePeriodo && cumpleSommelier)
                {
                    return true;
                }
            }
            return false;
        }

        public List<string> buscarDescripcionDeVarietal()
        {
            List <string> listaDescripcionVarietales = new List <string>();
            foreach(VinoVarietal vinoVar in varietales)
            {
                //getDescripcion();
                string descripcionVar = vinoVar.varietal.descripcion;
                listaDescripcionVarietales.Add(descripcionVar);
            }
            return listaDescripcionVarietales;
        }

        public string buscarRegionBodega() 
        { 
            return bodega.obtenerRegion();
        }
        public string buscarPaisBodega()
        {
            return bodega.obtenerPais();
        }
        public string buscarNombreBodega()
        {
            return bodega.nombre;
        }


        public double calcularPuntajeDeSommelierEnPeriodo(DateTime FechaDesde, DateTime FechaHasta)
        {
            double puntajeAcuReseña = 0;
            int contadorReseñasSommelier = 0;
            foreach(Reseña res in reseñas)
            {
                bool cumplePeriodo = res.sosDePeriodo(FechaDesde, FechaHasta);
                bool cumpleSommelier = res.sosDeSommelier();
                if (cumplePeriodo && cumpleSommelier)
                {
                    puntajeAcuReseña += res.puntaje;
                    contadorReseñasSommelier += 1;
                }
            }
            return calcularPuntajePromedio(puntajeAcuReseña, contadorReseñasSommelier);
        }

        public double calcularPuntajePromedio(double puntajeAcuReseña, int contadorReseñasSommelier)
        {
            //Traba el puntaje promedio en 1 decimal
            return Math.Truncate((puntajeAcuReseña / contadorReseñasSommelier) * 10) / 10;
            
        }

    }

}
