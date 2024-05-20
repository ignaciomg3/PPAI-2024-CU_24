using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Maridaje
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Constructor
        public Maridaje(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        // Método para mostrar la información del maridaje
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
        }

        public void MaridaConVino()
        {
            
            Console.WriteLine($"Descripción: {Descripcion}");

        }


    }

}
