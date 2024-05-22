using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Bodega
    {
        public string CoordenadasUbicacion { get; set; }
        public string Descripcion { get; set; }
        public string Historia { get; set; }
        public string Nombre { get; set; }
        public DateTime PeriodoActualizacion { get; set; }
        public RegionVitivinicola Region { get; set; }
        

        // Constructor
        public Bodega(string coordenadasUbicacion, string descripcion, string historia, string nombre, DateTime periodoActualizacion, RegionVitivinicola region)
        {
            CoordenadasUbicacion = coordenadasUbicacion;
            Descripcion = descripcion;
            Historia = historia;
            Nombre = nombre;
            PeriodoActualizacion = periodoActualizacion;
            Region = region;
        }

        // Método para contar las reseñas de la bodega
        public int ContarReseñas()
        {
            // Supongamos que las reseñas están almacenadas en algún lugar y se pueden contar
            return 0;
        }

        // Método para mostrar todos los vinos de la bodega
        public void MostrarTodosVinos()
        {
            // Supongamos que las Vinos están almacenados en algún lugar y se pueden contar

            Console.WriteLine($"Vinos de la Bodega {Nombre}:");
            //foreach (var vino in Vinos)
            //{
            //    Console.WriteLine(vino.Nombre);
            //}
        }
        public string obtenerRegion()
        {
            return Region.Nombre;
            
        }

        public string obtenerPais()
        {
            return Region.obtenerPais();
           
        }
    }
}
