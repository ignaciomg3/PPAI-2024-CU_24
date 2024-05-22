using CU_24_GenerarReporte.Boundary;
using CU_24_GenerarReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //creamos listas vacías.
        List<(Vino,decimal)> listaVinosyPromedio = new List<(Vino, decimal)>();
        List<(Vino, List<Reseña>)> listaVinoyReseñas = new List<(Vino, List<Reseña>)>();

        public List<(Vino, decimal)> listaVinoYPromedioAtributo  { get; set; }
        public List<(Vino, List<Reseña>)> listaVinoySusReseñasAtributo { get; set; }


        public Gestor(List<Vino> listaVinos, DateTime fechaDesde, DateTime fechaHasta, string tipoReseña, string tipoVisualizacion, PantallaPrincipal principal)
        {
            ListaVinos = listaVinos;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            TipoReseña = tipoReseña;
            TipoVisualizacion = tipoVisualizacion;
            pantallaPrincipalAtributo = principal;
            listaVinoYPromedioAtributo = listaVinosyPromedio;
            listaVinoySusReseñasAtributo = listaVinoyReseñas;
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
            MessageBox.Show("1er Loop - Buscando vinos que cumplan con los filtros");
            //creo una lista que contenga (vino con sus reseñas)
            List<(Vino, List<Reseña>)> ListaDeTuplasVinoYSusReseñasEnPySom = new List<(Vino,List<Reseña>)>();

              
            // 1er Loop (amarillo)
            // Vamos a recorrer TODOS los vinos para obtener sus reseñas q1ercumplan con el periodo y sean Premium.
            // [mientras haya vinos]
            foreach (Vino v in ListaVinos)
            {
                //Creo una lista para guardar las reseñas de Cada Vino que cumplan.  (2do loop)
                List<Reseña> reseñasDelVino =  v.tenesReseñasDeTipoEnPeriodo(FechaDesde, FechaHasta);

                //si tiene Reseñas enPeriodo y Premium entonces va a devolver una lista (no null).
                if (reseñasDelVino != null)
                {
                    //creo una variable tipo tupla(Vino,listaDeReseñas)
                    var tuplaVinoYsusReseñas = (v,reseñasDelVino);
                    //entonces lo agregamos la tupla(VyR) a la lista
                    ListaDeTuplasVinoYSusReseñasEnPySom.Add(tuplaVinoYsusReseñas);

                    //también lo agrego al atributo del gestor.
                    this.listaVinoySusReseñasAtributo.Add(tuplaVinoYsusReseñas);
                };
            }

            //3er Loop
            this.listaVinoYPromedioAtributo = calcularPuntajePromedioDeReseñasDeVinosValidados(ListaDeTuplasVinoYSusReseñasEnPySom);
            
            //Ordenamos de MAyor a menor por su promedio.
            OrdenarVinos();

            //rellenamos la grilla o creamos el Excel en su defecto.
            pantallaPrincipalAtributo.RellenarGrilla(ObtenerInformacionVinos());
        }

        public List<(Vino,decimal)> calcularPuntajePromedioDeReseñasDeVinosValidados(List<(Vino,List<Reseña>)> listaVinoySusReseñasValidadas)
        {
            //este método obtiene una lista de Vinos con sus respectivas reseñas y devuelve una lista de Vinos con sus respectivos promedios.
            MessageBox.Show("3er Loop - Calculando el promedio de puntuación de reseña de cada vino");

            var listaVinoYSuPromedio = new List<(Vino, decimal)>();

            //3er loop - Calculamos el promedio 
            foreach (var (vino, reseñas) in listaVinoySusReseñasValidadas)
            {
                if (reseñas.Count > 0)
                {
                    decimal puntajePromedio = (decimal)reseñas.Average(r => r.Puntaje);
                    listaVinoYSuPromedio.Add((vino, puntajePromedio));

                    //también lo agrego al atributo para controlar mas luego.
                    listaVinoYPromedioAtributo.Add((vino, puntajePromedio));
                }
                
            }
            return listaVinoYSuPromedio;

        }

        public void OrdenarVinos()
        {
            MessageBox.Show("Ordenando la lista de vinos según su promedio");
            this.listaVinoYPromedioAtributo.Sort((x, y) => y.Item2.CompareTo(x.Item2));

        }

        public List<(string, decimal, decimal, string, string, string, string)> ObtenerInformacionVinos()
        {
            List<(string, decimal,decimal, string, string, string, string)> listaDatos = new List<(string, decimal, decimal, string, string, string, string)>();

            //4to loop - Obtenemos su información. 
            foreach (var (vino, promedio) in this.listaVinoYPromedioAtributo)
            {
                //loop
                string nombreVino   = vino.Nombre;
                decimal calificacionPromedio = promedio;
                decimal precioVino = vino.PrecioARS;
                string nombreBodega = vino.Bodega.Nombre;
                string descripcionVarietal = string.Join(", ", vino.Varietales.Select(v => v.Descripcion));
                string nombreRegion = vino.Bodega.Region.Nombre;
                string nombrePais = vino.Bodega.Region.Provincia.Pais.Nombre;
                //string nombreProvincia = vino.Bodega.Region.Provincia.Nombre;


                (string nombre,
                decimal calificacionPromedio,
                decimal precioVino,
                string bodega,
                string descripcion,
                string region,
                string pais
                ) tuplaDatos = (nombreVino, calificacionPromedio, precioVino, nombreBodega, descripcionVarietal, nombreRegion, nombrePais);

                listaDatos.Add(tuplaDatos);

                Console.WriteLine($"Vino: {nombreVino}");
                Console.WriteLine($"Precio: {precioVino}");
                Console.WriteLine($"Bodega: {nombreBodega}");
                Console.WriteLine($"Region: {nombreRegion}");
                //Console.WriteLine($"Provincia: {nombreProvincia}");
                Console.WriteLine($"País: {nombrePais}");
                Console.WriteLine($"Varietal: {descripcionVarietal}");
                Console.WriteLine($"Promedio: {promedio}");
                Console.WriteLine();
            
            }
            return listaDatos;
        }

        public void SolicitarSelFechaDesdeYHasta()
        {

        }

        
    }

}
