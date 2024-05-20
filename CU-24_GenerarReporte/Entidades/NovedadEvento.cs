using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class NovedadEvento
    {
        public string CodigoDescuentoPremium { get; set; }
        public string Descripcion { get; set; }
        public bool EsSoloPremium { get; set; }
        public DateTime FechaHoraEvento { get; set; }
        public string NombreEvento { get; set; }        

        // Constructor
        public NovedadEvento(string codigoDescuentoPremium, string descripcion, bool esSoloPremium, DateTime fechaHoraEvento, string nombreEvento)
        {
            CodigoDescuentoPremium = codigoDescuentoPremium;
            Descripcion = descripcion;
            EsSoloPremium = esSoloPremium;
            FechaHoraEvento = fechaHoraEvento;
            NombreEvento = nombreEvento;
        }

        // Método para verificar si la novedad es para usuarios premium
        public bool EsPremium()
        {
            return EsSoloPremium;
        }

        // Método para verificar si la novedad está en período válido
        public bool EstaEnPeriodo()
        {
            // Supongamos que la novedad tiene un período de validez y comparamos la fecha actual con ese período
            DateTime fechaActual = DateTime.Now;
            // Supongamos que la novedad es válida durante un día
            DateTime fechaLimite = FechaHoraEvento.AddDays(1);
            return fechaActual <= fechaLimite;
        }

        // Método para mostrar la descripción de la novedad del evento
        public void MostrarDescripcion()
        {
            Console.WriteLine($"Nombre del Evento: {NombreEvento}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Fecha y Hora del Evento: {FechaHoraEvento}");
            Console.WriteLine($"Código de Descuento Premium: {CodigoDescuentoPremium}");
            Console.WriteLine($"¿Es solo para Premium?: {(EsSoloPremium ? "Sí" : "No")}");
        }
    }
}
