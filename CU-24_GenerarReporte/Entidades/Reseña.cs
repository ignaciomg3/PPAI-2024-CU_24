using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Reseña
    {
        public string Comentario { get; set; }
        public bool EsPremium { get; set; }
        public DateTime FechaReseña { get; set; }
        public int Puntaje { get; set; }

        
        
        // Constructor
        public Reseña(string comentario, bool esPremium, DateTime fechaReseña, int puntaje)
        {
            Comentario = comentario;
            EsPremium = esPremium;
            FechaReseña = fechaReseña;
            Puntaje = puntaje;
        }
       

        // Método para verificar si la reseña es premium
        public bool EsPremiumSioNo()
        {
            return EsPremium;
        }

        // Método para verificar si la reseña es de un enófilo
        public bool SosDeEnofilo()
        {
            // Lógica para determinar si la reseña es de un enófilo
            // Esto depende de cómo se defina un enófilo en tu sistema
            // Aquí ponemos un ejemplo simple
            return !EsPremium; // Suponemos que las reseñas no premium son de enófilos
        }

        // Método para verificar si la reseña es de un sommelier
        public bool SosDeSommelier()
        {
            // Lógica para determinar si la reseña es de un sommelier
            // Esto depende de cómo se defina un sommelier en tu sistema
            // Aquí ponemos un ejemplo simple
            return EsPremium; // Suponemos que las reseñas premium son de sommeliers
        }
        public bool SosDePeriodo(DateTime FechaDesde, DateTime FechaHasta)
        {
            if (this.FechaReseña > FechaDesde && this.FechaReseña < FechaHasta)
            {
                return true;
            }
            return false;
        }
    }
}
