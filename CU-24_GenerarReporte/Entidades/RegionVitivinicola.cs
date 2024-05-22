using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class RegionVitivinicola
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Provincia Provincia { get; set; }

        // Constructor
        public RegionVitivinicola(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        // Método para mostrar la información de la región vitivinícola
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
        }

        public string obtenerPais()
        {
            return Provincia.obtenerPais();
        }
    }
}
