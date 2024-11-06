using CU_24_GenerarReporte.Boundary;
using CU_24_GenerarReporte.Controlador;
using CU_24_GenerarReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_24_GenerarReporte
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Crear instancias de Varietal 
            Varietal varietal1 = new Varietal("Vino Tinto");
            Varietal varietal2 = new Varietal("Vino Blanco");
            List<Varietal> listaVarietales = new List<Varietal> { varietal1, varietal2 };


            // Crear instancias de RegionVitivinicola
            RegionVitivinicola region1 = new RegionVitivinicola("Valle de Napa");
            RegionVitivinicola region2 = new RegionVitivinicola("Valle de Casablanca");

            List<RegionVitivinicola> listaRegiones1 = new List<RegionVitivinicola> { region1, region2 };

            RegionVitivinicola region3 = new RegionVitivinicola("Valle del Ródano");
            RegionVitivinicola region4 = new RegionVitivinicola("Valle del Loira");

            List<RegionVitivinicola> listaRegiones2 = new List<RegionVitivinicola> { region3, region4 };

            RegionVitivinicola region5 = new RegionVitivinicola("Punilla");
            RegionVitivinicola region6 = new RegionVitivinicola("Calamuchita");

            List<RegionVitivinicola> listaRegiones3 = new List<RegionVitivinicola> { region5, region6 };

            // Crear instancias de Provincias
            Provincia provincia1 = new Provincia("Mendoza", listaRegiones1);
            Provincia provincia2 = new Provincia("Santiago del Estero", listaRegiones2);
            Provincia provincia3 = new Provincia("Cordoba", listaRegiones3);
            List<Provincia> listaProvincias1 = new List<Provincia> { provincia1, provincia2 };

            region1.provincia = provincia1;
            region2.provincia = provincia1;
            region3.provincia = provincia2;
            region4.provincia = provincia2;
            region5.provincia = provincia3;
            region6.provincia = provincia3;

            // Crear una instancia de País
            Pais pais1 = new Pais("Argentina", listaProvincias1);

            provincia1.pais = pais1;
            provincia2.pais = pais1;
            provincia3.pais = pais1;

            //Crear Reseñas
            //Primer Lista de Reseñas 
            Reseña reseñaSommelier1 = new Reseña(true, DateTime.Parse("2024-05-13"), 5);
            Reseña reseñaEnofilo1 = new Reseña(false, DateTime.Parse("2024-05-24"), 3);
            Reseña reseñaSommelier12 = new Reseña(true, DateTime.Parse("2024-04-13"), 4);
            Reseña reseñaEnofilo12 = new Reseña(false, DateTime.Parse("2024-05-23"), 4);
            Reseña reseñaSommelier13 = new Reseña(true, DateTime.Parse("2024-02-18"), 2);
            Reseña reseñaEnofilo13 = new Reseña(false, DateTime.Parse("2024-05-24"), 3);
            Reseña reseñaSommelier14 = new Reseña(true, DateTime.Parse("2024-04-13"), 3);
            Reseña reseñaEnofilo14 = new Reseña(false, DateTime.Parse("2024-05-23"), 4);
            Reseña reseñaSommelier15 = new Reseña(true, DateTime.Parse("2024-04-18"), 1);
            Reseña reseñaEnofilo15 = new Reseña(false, DateTime.Parse("2024-05-24"), 3);

            List<Reseña> listaReseñas1 = new List<Reseña>
        {
            reseñaEnofilo1,reseñaSommelier1, reseñaEnofilo12, reseñaSommelier12, reseñaEnofilo13, reseñaSommelier13, 
                reseñaEnofilo14, reseñaSommelier14, reseñaEnofilo15, reseñaSommelier15
        };

            //Segunda Lista de Reseñas //queda promedio 3
            Reseña reseñaSommelier2 = new Reseña(true, DateTime.Parse("2024-05-27"), 5);
            Reseña reseñaEnofilo2 = new Reseña(false, DateTime.Parse("2024-05-30"), 4);
            Reseña reseñaSommelier22 = new Reseña(true, DateTime.Parse("2023-04-27"), 2);
            Reseña reseñaEnofilo22 = new Reseña(false, DateTime.Parse("2024-05-03"), 2);
            Reseña reseñaSommelier23 = new Reseña(true, DateTime.Parse("2024-04-27"), 1);
            Reseña reseñaEnofilo23 = new Reseña(false, DateTime.Parse("2024-04-30"), 3);
            Reseña reseñaSommelier24 = new Reseña(true, DateTime.Parse("2024-01-20"), 4);
            Reseña reseñaEnofilo24 = new Reseña(false, DateTime.Parse("2024-03-30"), 1);

            List<Reseña> listaReseñas2 = new List<Reseña>
        {
            reseñaSommelier2,reseñaEnofilo2, reseñaSommelier22, reseñaEnofilo22, reseñaSommelier23, reseñaEnofilo23, reseñaSommelier24, reseñaEnofilo24
        };

            //Tercera Lista de Reseñas //promedio 3.1
            Reseña reseñaSommelier3 = new Reseña(true, DateTime.Parse("2024-05-10"), 2);
            Reseña reseñaEnofilo3 = new Reseña(false, DateTime.Parse("2024-05-30"), 4);
            Reseña reseñaSommelier32 = new Reseña(true, DateTime.Parse("2023-04-27"), 2);
            Reseña reseñaEnofilo32 = new Reseña(false, DateTime.Parse("2024-05-03"), 2);
            Reseña reseñaSommelier33 = new Reseña(true, DateTime.Parse("2024-04-27"), 1);
            Reseña reseñaEnofilo33 = new Reseña(false, DateTime.Parse("2024-04-30"), 3);
            Reseña reseñaSommelier34 = new Reseña(true, DateTime.Parse("2024-01-20"), 4);
            Reseña reseñaEnofilo34 = new Reseña(false, DateTime.Parse("2024-03-30"), 1);
            Reseña reseñaSommelier35 = new Reseña(true, DateTime.Parse("2023-11-15"), 3);
            Reseña reseñaEnofilo35 = new Reseña(false, DateTime.Parse("2024-02-20"), 2);
            Reseña reseñaSommelier36 = new Reseña(true, DateTime.Parse("2024-06-10"), 5);
            Reseña reseñaEnofilo36 = new Reseña(false, DateTime.Parse("2024-07-05"), 4);
            Reseña reseñaSommelier37 = new Reseña(true, DateTime.Parse("2024-08-12"), 3);
            Reseña reseñaEnofilo37 = new Reseña(false, DateTime.Parse("2024-09-14"), 2);
            Reseña reseñaSommelier38 = new Reseña(true, DateTime.Parse("2024-05-16"), 4);
            Reseña reseñaEnofilo38 = new Reseña(false, DateTime.Parse("2024-04-20"), 3);
            Reseña reseñaSommelier39 = new Reseña(true, DateTime.Parse("2024-04-25"), 5);
            Reseña reseñaEnofilo39 = new Reseña(false, DateTime.Parse("2024-01-10"), 4);
            Reseña reseñaSommelier310 = new Reseña(true, DateTime.Parse("2024-04-05"), 2);
            Reseña reseñaEnofilo310 = new Reseña(false, DateTime.Parse("2024-03-12"), 1);


            List<Reseña> listaReseñas3 = new List<Reseña>
        {
            reseñaSommelier3, reseñaEnofilo3, reseñaSommelier32, reseñaEnofilo32, reseñaSommelier33, reseñaEnofilo33,
                reseñaSommelier34, reseñaEnofilo34,reseñaSommelier35, reseñaEnofilo35,
                reseñaSommelier36, reseñaEnofilo36,reseñaSommelier37, reseñaEnofilo37,reseñaSommelier38, reseñaEnofilo38,
                reseñaSommelier39, reseñaEnofilo39,reseñaSommelier310, reseñaEnofilo310,
        };

            // Cuarta Lista de Reseñas 
            Reseña reseñaSommelier4 = new Reseña(true, DateTime.Parse("2024-05-10"), 5);
            Reseña reseñaEnofilo4 = new Reseña(false, DateTime.Parse("2024-05-30"), 4);
            Reseña reseñaSommelier42 = new Reseña(true, DateTime.Parse("2024-03-15"), 2);
            Reseña reseñaEnofilo42 = new Reseña(false, DateTime.Parse("2024-05-03"), 2);
            Reseña reseñaSommelier43 = new Reseña(true, DateTime.Parse("2024-04-27"), 1);
            Reseña reseñaEnofilo43 = new Reseña(false, DateTime.Parse("2024-04-30"), 3);
            Reseña reseñaSommelier44 = new Reseña(true, DateTime.Parse("2024-03-30"), 4);
            Reseña reseñaEnofilo44 = new Reseña(false, DateTime.Parse("2024-04-18"), 1);
            Reseña reseñaSommelier45 = new Reseña(true, DateTime.Parse("2024-05-20"), 5);
            Reseña reseñaEnofilo45 = new Reseña(false, DateTime.Parse("2024-04-10"), 2);
            Reseña reseñaSommelier46 = new Reseña(true, DateTime.Parse("2024-05-25"), 5);
            Reseña reseñaEnofilo46 = new Reseña(false, DateTime.Parse("2024-03-28"), 4);
            Reseña reseñaSommelier47 = new Reseña(true, DateTime.Parse("2024-05-05"), 3);
            Reseña reseñaEnofilo47 = new Reseña(false, DateTime.Parse("2024-04-12"), 2);
            Reseña reseñaSommelier48 = new Reseña(true, DateTime.Parse("2024-04-15"), 2);
            Reseña reseñaEnofilo48 = new Reseña(false, DateTime.Parse("2024-03-20"), 3);
            Reseña reseñaSommelier49 = new Reseña(true, DateTime.Parse("2024-05-16"), 4);
            Reseña reseñaEnofilo49 = new Reseña(false, DateTime.Parse("2024-04-25"), 3);
            Reseña reseñaSommelier410 = new Reseña(true, DateTime.Parse("2024-04-05"), 5);
            Reseña reseñaEnofilo410 = new Reseña(false, DateTime.Parse("2024-03-12"), 1);

            List<Reseña> listaReseñas4 = new List<Reseña>
            {
                reseñaSommelier4, reseñaEnofilo4, reseñaSommelier42, reseñaEnofilo42, reseñaSommelier43, reseñaEnofilo43,
                reseñaSommelier44, reseñaEnofilo44, reseñaSommelier45, reseñaEnofilo45,
                reseñaSommelier46, reseñaEnofilo46, reseñaSommelier47, reseñaEnofilo47, reseñaSommelier48, reseñaEnofilo48,
                reseñaSommelier49, reseñaEnofilo49, reseñaSommelier410, reseñaEnofilo410,
            };

            // Quinta Lista de Reseñas 
            Reseña reseñaSommelier5 = new Reseña(true, DateTime.Parse("2024-03-05"), 5);
            Reseña reseñaEnofilo5 = new Reseña(false, DateTime.Parse("2024-03-10"), 4);
            Reseña reseñaSommelier52 = new Reseña(true, DateTime.Parse("2024-03-15"), 2);
            Reseña reseñaEnofilo52 = new Reseña(false, DateTime.Parse("2024-03-20"), 1);
            Reseña reseñaSommelier53 = new Reseña(true, DateTime.Parse("2024-03-25"), 4);
            Reseña reseñaEnofilo53 = new Reseña(false, DateTime.Parse("2024-03-30"), 3);
            Reseña reseñaSommelier54 = new Reseña(true, DateTime.Parse("2024-04-05"), 5);
            Reseña reseñaEnofilo54 = new Reseña(false, DateTime.Parse("2024-04-10"), 2);
            Reseña reseñaSommelier55 = new Reseña(true, DateTime.Parse("2024-04-15"), 3);
            Reseña reseñaEnofilo55 = new Reseña(false, DateTime.Parse("2024-04-20"), 4);
            Reseña reseñaSommelier56 = new Reseña(true, DateTime.Parse("2024-04-25"), 5);
            Reseña reseñaEnofilo56 = new Reseña(false, DateTime.Parse("2024-04-30"), 5);
            Reseña reseñaSommelier57 = new Reseña(true, DateTime.Parse("2024-05-05"), 2);
            Reseña reseñaEnofilo57 = new Reseña(false, DateTime.Parse("2024-05-10"), 3);
            Reseña reseñaSommelier58 = new Reseña(true, DateTime.Parse("2024-05-15"), 4);
            Reseña reseñaEnofilo58 = new Reseña(false, DateTime.Parse("2024-05-20"), 5);
            Reseña reseñaSommelier59 = new Reseña(true, DateTime.Parse("2024-05-25"), 5);
            Reseña reseñaEnofilo59 = new Reseña(false, DateTime.Parse("2024-05-30"), 2);
            Reseña reseñaSommelier510 = new Reseña(true, DateTime.Parse("2024-03-12"), 5);
            Reseña reseñaEnofilo510 = new Reseña(false, DateTime.Parse("2024-03-17"), 1);

            List<Reseña> listaReseñas5 = new List<Reseña>
            {
                reseñaSommelier5, reseñaEnofilo5, reseñaSommelier52, reseñaEnofilo52, reseñaSommelier53, reseñaEnofilo53,
                reseñaSommelier54, reseñaEnofilo54, reseñaSommelier55, reseñaEnofilo55,
                reseñaSommelier56, reseñaEnofilo56, reseñaSommelier57, reseñaEnofilo57, reseñaSommelier58, reseñaEnofilo58,
                reseñaSommelier59, reseñaEnofilo59, reseñaSommelier510, reseñaEnofilo510,
            };



            //Creación de Bodega:
            Bodega bodega1 = new Bodega("Bodega en el Valle de Napa", region1);
            Bodega bodega2 = new Bodega("Bodega Catena Zapata", region2);
            Bodega bodega3 = new Bodega("Bodega Norton", region3);
            Bodega bodega4 = new Bodega("Bodega Zuccardi", region4);
            Bodega bodega5 = new Bodega("Bodega Trapiche", region5);
            Bodega bodega6 = new Bodega("Bodega Salentein", region6);
            Bodega bodega7 = new Bodega("Bodega Luigi Bosca", region1);
            Bodega bodega8 = new Bodega("Bodega El Esteco", region2);
            Bodega bodega9 = new Bodega("Bodega Colomé", region3);
            Bodega bodega10 = new Bodega("Bodega Familia Zuccardi", region4);
            Bodega bodega11 = new Bodega("Bodega Ruca Malen", region5);
            Bodega bodega12 = new Bodega("Bodega Domaine Bousquet", region6);

            //Creacion de Vinos
            Vino vino1 = new Vino("Vino Tinto Reserva", 1000.0m, bodega1, new List<Varietal> { varietal1, varietal2 }, listaReseñas1);
            Vino vino2 = new Vino("Vino Blanco Chardonnay", 850.0m, bodega2, new List<Varietal> { varietal2 }, listaReseñas2);
            Vino vino3 = new Vino("Vino Rosado", 750.0m, bodega3, new List<Varietal> { varietal1 }, listaReseñas3);
            Vino vino4 = new Vino("Vino Espumante Brut", 1200.0m, bodega4, new List<Varietal> { varietal2 }, listaReseñas4);
            Vino vino5 = new Vino("Vino Tinto Gran", 1500.0m, bodega5, new List<Varietal> { varietal1, varietal2 }, listaReseñas5);
            Vino vino6 = new Vino("Vino Blanco Sauvignon", 900.0m, bodega6, new List<Varietal> { varietal2 }, listaReseñas1);
            Vino vino7 = new Vino("Vino Naranja", 1100.0m, bodega7, new List<Varietal> { varietal1 }, listaReseñas2);
            Vino vino8 = new Vino("Vino Tinto de Guarda", 2000.0m, bodega8, new List<Varietal> { varietal2 }, listaReseñas3);
            Vino vino9 = new Vino("Vino Blanco Dulce", 950.0m, bodega9, new List<Varietal> { varietal1 }, listaReseñas4);
            Vino vino10 = new Vino("Vino Tinto Syrah", 1300.0m, bodega10, new List<Varietal> { varietal1 }, listaReseñas5);
            Vino vino11 = new Vino("Vino Catena Zapata", 4300.0m, bodega11, new List<Varietal> { varietal2 }, listaReseñas1);
            Vino vino12 = new Vino("Vino Norton Reserva", 1600.0m, bodega12, new List<Varietal> { varietal1, varietal2 }, listaReseñas2);
            Vino vino13 = new Vino("Vino Zuccardi Q Tempranillo", 3000.0m, bodega10, new List<Varietal> { varietal2 }, listaReseñas3);
            Vino vino14 = new Vino("Vino Salentein Primus Pinot Noir", 5800.0m, bodega1, new List<Varietal> { varietal1, varietal2 }, listaReseñas4);
            Vino vino15 = new Vino("Vino Luigi Bosca Gala 1", 2600.0m, bodega3, new List<Varietal> { varietal2 }, listaReseñas5);
            Vino vino16 = new Vino("Vino Tinto Uvita", 3100.0m, bodega5, new List<Varietal> { varietal1 }, listaReseñas1);
            Vino vino17 = new Vino("Vino Altos de Mendoza", 8000.0m, bodega1, new List<Varietal> { varietal2 }, listaReseñas2);
            Vino vino18 = new Vino("Vino Patagonia", 6300.0m, bodega2, new List<Varietal> { varietal1 }, listaReseñas3);
            Vino vino19 = new Vino("Vino Andes Grand", 2100.0m, bodega3, new List<Varietal> { varietal1, varietal2 }, listaReseñas4);
            Vino vino20 = new Vino("Vino Torrontés del Sol", 1300.0m, bodega6, new List<Varietal> { varietal1 }, listaReseñas5);

            // Creación de objetos de la clase Vino (se reutilizan los objetos creados previamente)
            List<Vino> listaVinos = new List<Vino>
            {
            vino1, vino2, vino3, vino4, vino5, vino6, vino7, vino8, vino9, vino10, vino11, vino12, vino13, vino14, vino15, vino16, vino17,
            vino18, vino19, vino20
            };

            //Pasar lista de vinos a la pantalla
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login(listaVinos));
            Application.Run(new AccesoAdatos());

        }
    }
}
