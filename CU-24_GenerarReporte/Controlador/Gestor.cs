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
        //static PantallaPrincipal principalNueva;
        public List<Vino> ListaVinos { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string TipoReseña { get; set; }
        public string TipoVisualizacion { get; set; }

        private PantallaPrincipal pantallaPrincipalAtributo;

        public Gestor(List<Vino> listaVinos, DateTime fechaDesde, DateTime fechaHasta, string tipoReseña, string tipoVisualizacion, PantallaPrincipal principal)
        {
            ListaVinos = listaVinos;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            TipoReseña = tipoReseña;
            TipoVisualizacion = tipoVisualizacion;
            pantallaPrincipalAtributo = principal;
        }
        
        // Implementación de métodos adicionales si es necesario
        public void OpcionGenerarRankingVinos()
        {
            pantallaPrincipalAtributo.SolicitarSelFechaDesdeYHasta();
        }
        public void TomarSelFechaDesdeYHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.FechaDesde = fechaDesde;
            this.FechaHasta = fechaHasta;

            pantallaPrincipalAtributo.SolicitarSelTipoReseña();
        }
        public void TomarSeleccionTipoReseña(string tipoReseña)
        {
            this.TipoReseña = tipoReseña;

        }
        public void TomarSelTipoVisualizacion(string tipoVisualizacion)
        {
            this.TipoVisualizacion = tipoVisualizacion;

            pantallaPrincipalAtributo.SolicitarConfirmacionGenReporte();
        }

        public void TomarConfirmacionGenReporte()
        {
            BuscarVinosConReseñaEnPeriodos();
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
