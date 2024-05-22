using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Pais
    {
        public string Nombre { get; set; }
        public List<Provincia> Provincias { get; set; }

        // Constructor
        public Pais(string nombre, List<Provincia> provincias)
        {
            Nombre = nombre;
            Provincias = provincias;
        }

        // Método para contar las provincias en el país
        public int ContarProvincias()
        {
            return Provincias.Count;
        }

        // Método para mostrar las provincias del país
        public void MostrarProvincias()
        {
            Console.WriteLine($"Provincias en el País {Nombre}:");
            foreach (var provincia in Provincias)
            {
                Console.WriteLine(provincia.Nombre);
            }
        }

        // Método para contar las bodegas en el país
        public int ContarBodegas()
        {
            int totalBodegas = 0;
            foreach (var provincia in Provincias)
            {
                totalBodegas += provincia.ContarRegiones(); // Suma el total de bodegas de todas las provincias
            }
            return totalBodegas;
        }
        
        public void MostrarInformacion()
        {
            // Mostrar información del país
            Console.WriteLine($"País: {Nombre}");
            Console.WriteLine($"Cantidad de Provincias: {ContarProvincias()}");
            Console.WriteLine($"Cantidad de Bodegas: {ContarBodegas()}");
            
        }

    }
}
