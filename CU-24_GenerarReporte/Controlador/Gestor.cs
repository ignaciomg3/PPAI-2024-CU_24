using CU_24_GenerarReporte.Boundary;
using CU_24_GenerarReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Controlador
{
    public class Gestor
    {
        public List<Vino> ListaVinos { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string TipoReseña { get; set; }
        public string TipoVisualizacion { get; set; }

        private PantallaPrincipal principal;

        public Gestor(List<Vino> listaVinos, DateTime fechaDesde, DateTime fechaHasta, string tipoReseña, string tipoVisualizacion)
        {
            ListaVinos = listaVinos;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            TipoReseña = tipoReseña;
            TipoVisualizacion = tipoVisualizacion;
        }
        
        // Implementación de métodos adicionales si es necesario
        public void OpcionGenerarRankingVinos()
        {
            
        }
        public void TomarSelFechaDesdeYHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.FechaDesde= fechaDesde;
            this.FechaHasta= fechaHasta;
        }
        public void TomarSeleccionTipoReseña(string tipoReseña)
        {
            this.TipoReseña = tipoReseña;

        }
        public void TomarSeleccioTipoVisualizazcion()
        {

        }
        public void BuscarVinosConReseñaEnPeriodos()
        {
            //loop
        }

    public void SolicitarSelFechaDesdeYHasta()
        {

        }

        
    }

}
