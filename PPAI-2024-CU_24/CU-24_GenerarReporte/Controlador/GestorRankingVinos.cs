using CU_24_GenerarReporte.Boundary;
using CU_24_GenerarReporte.Entidades;
using CU_24_GenerarReporte.Interfaces;
using CU_24_GenerarReporte.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_24_GenerarReporte.Controlador
{
     
    public class GestorRankingVinos
    {
        public List<Vino> listaVinos { get; set; }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }

        //Estos metodos solo sirven como comprobacion para el seguimiento normal del CU
        public string tipoReseña { get; set; }
        public string tipoVisualizacion { get; set; }

        private IEstrategiaReporte _estrategiaReporte { get; set; }
        private IEstrategiaVisualizacion _estrategiaVisualizacion { get; set; }

        private PantallaRankingVinos pantallaPrincipalAtributo;


        public GestorRankingVinos(List<Vino> listaVinos, PantallaRankingVinos principal, IEstrategiaReporte estrategiaReporte, IEstrategiaVisualizacion estrategiaVisualizacion)
        {
            this.listaVinos = listaVinos;
            pantallaPrincipalAtributo = principal;
            _estrategiaReporte = estrategiaReporte;
            _estrategiaVisualizacion = estrategiaVisualizacion;
        }

        public void opcionGenerarRankingVinos()
        {
            pantallaPrincipalAtributo.solicitarSelFechaDesdeYHasta();
        }


        public void tomarSelFechaDesdeYHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;

            pantallaPrincipalAtributo.solicitarSelTipoReseña();
        }


        public void tomarSelTipoReseña(string tipoReseña)
        {
            this.tipoReseña = tipoReseña;
            crearEstrategiaTipoReseña(tipoReseña);
            pantallaPrincipalAtributo.solicitarSelTipoVisualizacion();
        }

        //MockUp, no importa lo que seleccione, creara la estrategia para reseñas del tipo Sommelier.
        public void crearEstrategiaTipoReseña(string tipoReseña)
        {
            if (tipoReseña == "Sommelier")
            {
               this._estrategiaReporte = new ReporteReseñaSommelier();
            }
            else if (tipoReseña == "Normales")
            {
                this._estrategiaReporte = new ReporteReseñaSommelier();
            }
            else if (tipoReseña == "Amigos")
            {
                this._estrategiaReporte = new ReporteReseñaSommelier();
            }
        }

        public void tomarSelTipoVisualizacion(string tipoVisualizacion)
        {
            this.tipoVisualizacion = tipoVisualizacion;
            crearEstrategiaTipoVisualizacion(tipoVisualizacion);
            pantallaPrincipalAtributo.solicitarConfirmacionGenReporte();
        }

        //MockUp, no tiene estrategia para mostrar por pantalla, generara por Excel en el caso que se seleccione.
        public void crearEstrategiaTipoVisualizacion(string tipoVisualizacion)
        {
            if (tipoVisualizacion == "Excel")
            {
                this._estrategiaVisualizacion = new VisualizacionExcel();
            }
            else if (tipoVisualizacion == "PDF")
            {
                this._estrategiaVisualizacion = new VisualizacionPDF();
            }
            else if (tipoVisualizacion == "Pantalla")
            {
                this._estrategiaVisualizacion = new VisualizacionExcel();
            }
        }

        public void tomarConfirmacionGenReporte()
        {
            //Comprueba que se selecciono el tipo de reseña sommelier y no se selecciono la visualizacion por pantalla
            //En caso de tener otras selecciones no hace nada
            if (tipoReseña == "Sommelier" && tipoVisualizacion != "Pantalla")
            {
                calcularRankingOrdenado();
            }
        }

        public void calcularRankingOrdenado()
        {
            List<List<string>> listaOrdenada = this._estrategiaReporte.calcularRankingOrdenado(listaVinos, fechaDesde, fechaHasta);
            if (listaOrdenada == null)
            {
                pantallaPrincipalAtributo.noHayReseñasSommelier();
            }
            else 
            { 
                visualizarRanking(listaOrdenada); 
            }
        }

        public void visualizarRanking(List<List<string>> listaOrdenada)
        {
            bool rankingCreado = _estrategiaVisualizacion.visualizarRanking(listaOrdenada);

            pantallaPrincipalAtributo.confirmarExportacion(rankingCreado);

            finCU();
        }

        public void finCU()
        {
            Console.WriteLine("Fin de Caso De Uso");
        }
        
    }

}
