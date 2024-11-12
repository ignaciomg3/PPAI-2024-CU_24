using CU_24_GenerarReporte.Boundary;
using CU_24_GenerarReporte.Entidades;
using CU_24_GenerarReporte.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_24_GenerarReporte.Objetos
{
    public class ReporteReseñaSommelier : IEstrategiaReporte
    {
        //Metodo Polimorfico
        public List<List<string>> calcularRankingOrdenado(List<Vino> listaVinos, DateTime FechaDesde, DateTime FechaHasta)
        {
            List<List<string>> listaOrdenada = buscarVinosConReseñaEnPeriodos(listaVinos,FechaDesde,FechaHasta);
            return listaOrdenada;
        }

        public List<List<string>> buscarVinosConReseñaEnPeriodos(List<Vino> listaVinos, DateTime FechaDesde, DateTime FechaHasta)

        {
            List<Vino> vinosAgregados = new List<Vino>();

            List<List<string>> listaDatosTodosLosVinos = new List<List<string>>();

            foreach (Vino vino in listaVinos)
            {
                bool vinoConSommelierYPeriodo = vino.tenesReseñasDeTipoEnPeriodo(FechaDesde, FechaHasta);
                if (vinoConSommelierYPeriodo)
                {
                    List<string> listaDatosUnVino = new List<string>();
                    //Agrego Cada vino con Sommelier y Periodo en la lista vinosAgregados
                    vinosAgregados.Add(vino);

                    //Nombre de Vino; getNombre()
                    string nombreVino = vino.nombre;
                    //Precio de Vino; getPrecio()
                    decimal precioVino = vino.precioARS;
                    string precioVinoStr = precioVino.ToString();

                    //Nombre de Bodega;
                    string nombreBodega = vino.buscarNombreBodega();
                    //Nombre de Region
                    string nombreRegion = vino.buscarRegionBodega();
                    //Nombre de Pais
                    string nombrePais = vino.buscarPaisBodega();

                    //Descripcion de Varietales
                    List<string> listaDescVarietales = vino.buscarDescripcionDeVarietal();
                    string descVarietales = string.Join(", ", listaDescVarietales);

                    // carga los datos en una lista
                    listaDatosUnVino.Add(nombreVino);
                    listaDatosUnVino.Add(precioVinoStr);
                    listaDatosUnVino.Add(nombreBodega);
                    listaDatosUnVino.Add(nombreRegion);
                    listaDatosUnVino.Add(nombrePais);
                    listaDatosUnVino.Add(descVarietales);

                    // carga de listaDeUnVino en otra listaDeTodosLosVinos
                    listaDatosTodosLosVinos.Add(listaDatosUnVino);
                }

            }
            if (listaDatosTodosLosVinos.Count == 0)
            {
                return null;
            }
            else
            {
                return calcularPuntajeDeSommelierEnPeriodo(vinosAgregados, listaDatosTodosLosVinos, FechaDesde, FechaHasta);
            }


        }

        public List<List<string>> calcularPuntajeDeSommelierEnPeriodo(List<Vino> vinosAgregados, List<List<string>> listaDeDatosTodosLosVinos, DateTime FechaDesde, DateTime FechaHasta)
        {
            //2do Loop - Recorre Vinos que cumplen con Filtro
            //[mientras haya vinos que cumplen con los filtros]

            for (int i = 0; i < vinosAgregados.Count; i++)
            {
                Vino vinoAEvaluar = vinosAgregados[i];

                // Calcular el puntaje promedio para el vino en el periodo especificado
                double puntajePromedio = vinoAEvaluar.calcularPuntajeDeSommelierEnPeriodo(FechaDesde, FechaHasta);

                // Convertir el puntaje a string y agregarlo a la sublista correspondiente
                listaDeDatosTodosLosVinos[i].Add(puntajePromedio.ToString());
            }
             return ordenarVinos(listaDeDatosTodosLosVinos);

        }

        public List<List<string>> ordenarVinos(List<List<string>> listaDeDatosTodosLosVinos)
        {
            for (int i = 0; i < listaDeDatosTodosLosVinos.Count - 1; i++)
            {
                // Guardar el puntaje promedio de la sublista actual
                double puntajeActual = double.Parse(listaDeDatosTodosLosVinos[i][6]);

                // Iterar sobre las sublistas restantes para comparar el puntaje promedio
                for (int j = i + 1; j < listaDeDatosTodosLosVinos.Count; j++)
                {
                    // Guardar el puntaje promedio de la sublista a comparar
                    double puntajeAComparar = double.Parse(listaDeDatosTodosLosVinos[j][6]);

                    // Si el puntaje promedio actual es menor que el puntaje a comparar, intercambiar las sublistas
                    if (puntajeActual < puntajeAComparar)
                    {
                        List<string> temp = listaDeDatosTodosLosVinos[i];
                        listaDeDatosTodosLosVinos[i] = listaDeDatosTodosLosVinos[j];
                        listaDeDatosTodosLosVinos[j] = temp;

                        // Actualizar el puntaje promedio actual
                        puntajeActual = puntajeAComparar;
                    }
                }
            }

            List<List<string>> listaOrdenada = new List<List<string>>();
            if (listaDeDatosTodosLosVinos.Count > 10)
            {
                listaOrdenada = listaDeDatosTodosLosVinos.Take(10).ToList();
            }
            else
            {
                listaOrdenada = listaDeDatosTodosLosVinos;
            }

            return listaOrdenada;
        }
    }
}
