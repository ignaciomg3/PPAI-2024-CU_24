using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    using System;

    public class Certificacion
    {
        public string AdjuntoURL { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public string InstitucionOtorgante { get; set; }
        public string Nombre { get; set; }

        // Constructor
        public Certificacion(string adjuntoURL, string descripcion, DateTime fechaFin, DateTime fechaInicio, string institucionOtorgante, string nombre)
        {
            AdjuntoURL = adjuntoURL;
            Descripcion = descripcion;
            FechaFin = fechaFin;
            FechaInicio = fechaInicio;
            InstitucionOtorgante = institucionOtorgante;
            Nombre = nombre;
        }

        // Método para verificar si la certificación está en periodo activo
        public bool EsEnPeriodo()
        {
            DateTime now = DateTime.Now;
            return now >= FechaInicio && now <= FechaFin;
        }

        // Método para mostrar la institución otorgante
        public void MostrarInstitucion()
        {
            Console.WriteLine($"Institución Otorgante: {InstitucionOtorgante}");
        }

        // Método para ver el adjunto (aquí simplemente imprimimos la URL)
        public void VerAdjunto()
        {
            Console.WriteLine($"URL del Adjunto: {AdjuntoURL}");
        }
    }

}
