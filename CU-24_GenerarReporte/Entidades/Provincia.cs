using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Provincia
    {
        public string Nombre { get; set; }
        public List<RegionVitivinicola> Regiones { get; set; }

        // Constructor
        public Provincia(string nombre)
        {
            Nombre = nombre;
            Regiones = new List<RegionVitivinicola>();
        }

        // Método para contar las regiones vitivinícolas en la provincia
        public int ContarRegiones()
        {
            return Regiones.Count;
        }

        // Método para mostrar las regiones vitivinícolas de la provincia
        public void MostrarRegiones()
        {
            Console.WriteLine($"Regiones en la Provincia de {Nombre}:");
            foreach (var region in Regiones)
            {
                region.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
