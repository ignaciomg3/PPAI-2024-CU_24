using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    public class Varietal
    {
        public string Descripcion { get; set; }
        public double PorcentajeComposicion { get; set; }
        public TipoUva TipoUva { get; set; }

        // Constructor
        public Varietal(string descripcion, double porcentajeComposicion, TipoUva tipoUva)
        {
            Descripcion = descripcion;
            PorcentajeComposicion = porcentajeComposicion;
            TipoUva = tipoUva;
        }

        // Método para conocer el tipo de uva
        public TipoUva ConocerTipoUva()
        {
            return TipoUva;
        }

        // Método para verificar si es de un tipo de uva específico
        public bool EsDeTipoUva(TipoUva tipoUva)
        {
            return TipoUva.Nombre == tipoUva.Nombre;
        }

        // Método para mostrar el porcentaje de composición
        public void MostrarPorcentaje()
        {
            Console.WriteLine($"Porcentaje de Composición: {PorcentajeComposicion}%");
        }
    }
}
