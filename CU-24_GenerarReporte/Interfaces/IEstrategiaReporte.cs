using CU_24_GenerarReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Interfaces
{
    public interface IEstrategiaReporte
    {
        List<List<string>> calcularRankingOrdenado(List<Vino> listaVinos, DateTime FechaDesde, DateTime FechaHasta);
    }
}
