using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Entidades
{
    

    public class CobroPremium
    {
        public bool EsAnual { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string NroOperacionMercadoPago { get; set; }

        // Constructor
        public CobroPremium(bool esAnual, DateTime fechaPago, decimal monto, string nroOperacionMercadoPago)
        {
            EsAnual = esAnual;
            FechaPago = fechaPago;
            Monto = monto;
            NroOperacionMercadoPago = nroOperacionMercadoPago;
        }

        // Método para mostrar la información del cobro
        public void MostrarInformacion()
        {
            Console.WriteLine($"Es Anual: {EsAnual}");
            Console.WriteLine($"Fecha de Pago: {FechaPago}");
            Console.WriteLine($"Monto: {Monto}");
            Console.WriteLine($"Número de Operación Mercado Pago: {NroOperacionMercadoPago}");
        }
    }

}
