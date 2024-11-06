using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Reseña
    {
        public bool esPremium { get; set; }
        public DateTime fechaReseña { get; set; }
        public int puntaje { get; set; }
        
        // Constructor
        public Reseña(bool esPremium, DateTime fechaReseña, int puntaje)
        {
            this.esPremium = esPremium;
            this.fechaReseña = fechaReseña;
            this.puntaje = puntaje;
        }
     

        // Método para verificar si la reseña es de un sommelier
        public bool sosDeSommelier()
        {
            return esPremium; // Suponemos que las reseñas premium son de sommeliers
        }
        public bool sosDePeriodo(DateTime FechaDesde, DateTime FechaHasta)
        {
            if (this.fechaReseña > FechaDesde && this.fechaReseña < FechaHasta)
            {
                return true;
            }
            return false;
        }
    }
}
