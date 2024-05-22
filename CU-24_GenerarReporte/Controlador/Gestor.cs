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

        List<(Vino,string)> listaVinosValidadosConPais = new List<(Vino, string)>();

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
            List<Vino> vinosAgregados_SommelierYPeriodo = new List<Vino>();

            //List<(Vino,string)> listaVinosValidados_Pais = new List<(Vino,string)>();
            //List<Vino> listaDeObjetosVino = new List<Vino>();

            //primer Loop
            foreach (Vino vino in ListaVinos)
            {
                Vino vinoConSommelierYPeriodo = vino.tenesReseñasDeTipoEnPeriodo(vino, FechaDesde, FechaHasta);
                if (vinoConSommelierYPeriodo != null)
                {
                    vinosAgregados_SommelierYPeriodo.Add(vinoConSommelierYPeriodo);
                }
            }   

            foreach (Vino vinoValidado in vinosAgregados_SommelierYPeriodo)
            {
                //acá hay que hacer:
                //getNombre
                //getPrecio
                //buscarInfoBodega

                //Tomamos el Vino y el País de la bodega, lo ponemos en una tupla.
                string nombrePais = vinoValidado.Bodega.obtenerPais();
                (Vino, string) tuplaVinoPais = (vinoValidado,nombrePais);

                //Agregamos la tupla al atributo lista del Gestor:
                this.listaVinosValidadosConPais.Add(tuplaVinoPais);
            }

        }

        public void calcularPuntajePromedioDeReseñasDeVinosValidados()
        {
            int valor = 0;
            foreach((Vino,string) tupla in this.listaVinosValidadosConPais)
            {
                tupla.Item1.CalcularPuntajeDeSommelierEnPeriodo(FechaDesde, FechaHasta);
            }
            
        }

        public void OrdenarVinos()
        {
            listaVinosValidadosConPais.Sort((x, y) => y.Item1.promedioPuntajePromedioSommelier.CompareTo(x.Item1.promedioPuntajePromedioSommelier));
        }
        public void SolicitarSelFechaDesdeYHasta()
        {

        }

        
    }

}
