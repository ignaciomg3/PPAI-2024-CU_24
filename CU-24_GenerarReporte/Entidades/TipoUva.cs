using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class TipoUva
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public TipoUva(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        // Método para mostrar la información de la uva
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
        }
    }

}
