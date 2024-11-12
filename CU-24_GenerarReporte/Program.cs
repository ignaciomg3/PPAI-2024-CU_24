using CU_24_GenerarReporte.Controlador;
using CU_24_GenerarReporte.Data;
using CU_24_GenerarReporte.Entidades;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
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
            List<Vino> listaVinos = new List<Vino>();

            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                listaVinos = context.Vinos
                    .Include(v => v.bodega)
                        .ThenInclude(b => b.region)
                            .ThenInclude(r => r.provincia)
                                .ThenInclude(p => p.pais)
                    .Include(v => v.varietales)
                        .ThenInclude(v => v.varietal)// Incluye los varietales si están relacionados muchos a muchos
                    .Include(v => v.reseñas) // Incluye las reseñas asociadas
                    .ToList();

                foreach (var vino in listaVinos)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Vino: {vino.nombre}, Precio: {vino.precioARS}");
                    Console.WriteLine($"  Bodega: {vino.bodega.nombre}");
                    Console.WriteLine($"  Región: {vino.bodega.region.nombre}");
                    Console.WriteLine($"  Provincia: {vino.bodega.region.provincia.nombre}");
                    Console.WriteLine($"  País: {vino.bodega.region.provincia.pais.nombre}");

                    Console.WriteLine("  Varietales:");
                    foreach (VinoVarietal varietal in vino.varietales)
                    {
                        Console.WriteLine($"    - {varietal.varietal.descripcion}");
                    }

                    Console.WriteLine("  Reseñas:");
                    foreach (var reseña in vino.reseñas)
                    {
                        Console.WriteLine($"    - Fecha: {reseña.fechaReseña}, Puntaje: {reseña.puntaje}, Es Premium: {reseña.esPremium}");
                    }
                }

                //DESCOMENTAR PARA POPULAR BASE DE DATOS (no hace falta, ya esta creada la bd)
                //var pais1 = new Pais { nombre = "Argentina" };
                //context.Paises.Add(pais1);

                //var varietal1 = new Varietal { descripcion = "Vino Tinto" };
                //var varietal2 = new Varietal { descripcion = "Vino Blanco" };
                //context.Varietales.AddRange(varietal1, varietal2);

                //var provincia1 = new Provincia { nombre = "Córdoba", pais = pais1 };
                //var provincia2 = new Provincia { nombre = "Mendoza", pais = pais1 };
                //var provincia3 = new Provincia { nombre = "San Juan", pais = pais1 };
                //context.Provincias.AddRange(provincia1, provincia2, provincia3);

                //var region1 = new RegionVitivinicola { nombre = "region1C", provincia = provincia1 };
                //var region2 = new RegionVitivinicola { nombre = "region2C", provincia = provincia1 };
                //var region3 = new RegionVitivinicola { nombre = "region1M", provincia = provincia2 };
                //var region4 = new RegionVitivinicola { nombre = "region2M", provincia = provincia2 };
                //var region5 = new RegionVitivinicola { nombre = "region1SJ", provincia = provincia3 };
                //var region6 = new RegionVitivinicola { nombre = "region2SJ", provincia = provincia3 };
                //context.RegionesVitivinicola.AddRange(region1,region2,region3,region4,region5,region6);

                //var bodega1 = new Bodega { nombre = "bodega1region1", region = region1 };
                //var bodega2 = new Bodega { nombre = "bodega2region1", region = region1 };

                //var bodega3 = new Bodega { nombre = "bodega1region2", region = region2 };
                //var bodega4 = new Bodega { nombre = "bodega2region2", region = region2 };

                //var bodega5 = new Bodega { nombre = "bodega1region3", region = region3 };
                //var bodega6 = new Bodega { nombre = "bodega2region3", region = region3 };

                //var bodega7 = new Bodega { nombre = "bodega1region4", region = region4 };
                //var bodega8 = new Bodega { nombre = "bodega2region4", region = region4 };

                //var bodega9 = new Bodega { nombre = "bodega1region5", region = region5 };
                //var bodega10 = new Bodega { nombre = "bodega2region5", region = region5 };

                //var bodega11 = new Bodega { nombre = "bodega1region6", region = region6 };
                //var bodega12 = new Bodega { nombre = "bodega2region6", region = region6 };
                //context.Bodegas.AddRange(bodega1, bodega2,
                //                            bodega3, bodega4,
                //                            bodega5, bodega6,
                //                            bodega7, bodega8,
                //                            bodega9, bodega10,
                //                            bodega11, bodega12);

                //var vino1 = new Vino { nombre = "vino1bodega1", precioARS = 10, bodega = bodega1 };
                //vino1.varietales.Add(new VinoVarietal { vino=vino1, varietal=varietal1});
                //var vino2 = new Vino { nombre = "vino2bodega1", precioARS = 20, bodega = bodega1 };
                //vino2.varietales.Add(new VinoVarietal { vino = vino2, varietal = varietal1 });
                //vino2.varietales.Add(new VinoVarietal { vino = vino2, varietal = varietal2 });
                //var vino3 = new Vino { nombre = "vino1bodega2", precioARS = 10, bodega = bodega2 };
                //vino3.varietales.Add(new VinoVarietal { vino = vino3, varietal = varietal1 });
                //vino3.varietales.Add(new VinoVarietal { vino = vino3, varietal = varietal2 });
                //var vino4 = new Vino { nombre = "vino1bodega3", precioARS = 10, bodega = bodega3 };
                //vino4.varietales.Add(new VinoVarietal { vino = vino4, varietal = varietal2 });
                //var vino5 = new Vino { nombre = "vino1bodega4", precioARS = 10, bodega = bodega4 };
                //vino5.varietales.Add(new VinoVarietal { vino = vino5, varietal = varietal1 });
                //vino5.varietales.Add(new VinoVarietal { vino = vino5, varietal = varietal2 });
                //var vino6 = new Vino { nombre = "vino1bodega5", precioARS = 10, bodega = bodega5 };
                //vino6.varietales.Add(new VinoVarietal { vino = vino6, varietal = varietal2 });
                //var vino7 = new Vino { nombre = "vino1bodega6", precioARS = 10, bodega = bodega6 };
                //vino7.varietales.Add(new VinoVarietal { vino = vino7, varietal = varietal1 });
                //var vino8 = new Vino { nombre = "vino1bodega7", precioARS = 10, bodega = bodega7 };
                //vino8.varietales.Add(new VinoVarietal { vino = vino8, varietal = varietal1 });
                //var vino9 = new Vino { nombre = "vino1bodega8", precioARS = 10, bodega = bodega8 };
                //vino9.varietales.Add(new VinoVarietal { vino = vino9, varietal = varietal1 });
                //var vino10 = new Vino { nombre = "vino1bodega9", precioARS = 10, bodega = bodega9 };
                //vino10.varietales.Add(new VinoVarietal { vino = vino10, varietal = varietal1 });
                //var vino11 = new Vino { nombre = "vino1bodega10", precioARS = 10, bodega = bodega10 };
                //vino11.varietales.Add(new VinoVarietal { vino = vino11, varietal = varietal2 });
                //var vino12 = new Vino { nombre = "vino1bodega11", precioARS = 10, bodega = bodega11 };
                //vino12.varietales.Add(new VinoVarietal { vino = vino12, varietal = varietal1 });
                //var vino13 = new Vino { nombre = "vino1bodega12", precioARS = 10, bodega = bodega12 };
                //vino13.varietales.Add(new VinoVarietal { vino = vino13, varietal = varietal1 });
                //vino13.varietales.Add(new VinoVarietal { vino = vino13, varietal = varietal2 });
                //context.Vinos.AddRange(vino1, vino2,
                //                            vino3, vino4,
                //                            vino5, vino6,
                //                            vino7, vino8,
                //                            vino9, vino10,
                //                            vino11, vino12, vino13);


                //var reseñasLista = new List<Reseña>
                //{
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-01-05"), puntaje = 3, vino = vino1 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-01-12"), puntaje = 4, vino = vino2 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-01-20"), puntaje = 5, vino = vino3 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-02-01"), puntaje = 2, vino = vino4 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-02-10"), puntaje = 4, vino = vino5 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-02-15"), puntaje = 3, vino = vino6 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-02-28"), puntaje = 5, vino = vino7 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-03-03"), puntaje = 1, vino = vino8 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-03-10"), puntaje = 2, vino = vino9 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-03-17"), puntaje = 3, vino = vino10 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-03-25"), puntaje = 4, vino = vino11 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-04-01"), puntaje = 5, vino = vino12 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-04-10"), puntaje = 2, vino = vino13 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-04-20"), puntaje = 3, vino = vino1 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-04-30"), puntaje = 5, vino = vino2 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-05-05"), puntaje = 4, vino = vino3 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-05-12"), puntaje = 1, vino = vino4 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-05-20"), puntaje = 3, vino = vino5 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-05-28"), puntaje = 2, vino = vino6 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-06-02"), puntaje = 4, vino = vino7 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-06-10"), puntaje = 5, vino = vino8 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-06-15"), puntaje = 1, vino = vino9 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-06-20"), puntaje = 3, vino = vino10 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-06-25"), puntaje = 4, vino = vino11 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-07-01"), puntaje = 2, vino = vino12 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-07-05"), puntaje = 5, vino = vino13 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-07-10"), puntaje = 1, vino = vino1 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-07-15"), puntaje = 3, vino = vino2 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-07-20"), puntaje = 4, vino = vino3 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-07-25"), puntaje = 2, vino = vino4 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-08-01"), puntaje = 3, vino = vino5 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-08-05"), puntaje = 4, vino = vino6 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-08-10"), puntaje = 2, vino = vino7 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-08-15"), puntaje = 5, vino = vino8 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-08-20"), puntaje = 1, vino = vino9 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-08-25"), puntaje = 3, vino = vino10 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-09-01"), puntaje = 5, vino = vino11 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-09-05"), puntaje = 4, vino = vino12 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-09-10"), puntaje = 2, vino = vino13 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-09-15"), puntaje = 3, vino = vino1 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-09-20"), puntaje = 1, vino = vino2 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-09-25"), puntaje = 5, vino = vino3 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-10-01"), puntaje = 3, vino = vino4 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-10-05"), puntaje = 2, vino = vino5 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-10-10"), puntaje = 4, vino = vino6 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-10-15"), puntaje = 5, vino = vino7 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-10-20"), puntaje = 1, vino = vino8 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-10-25"), puntaje = 3, vino = vino9 },
                //    new Reseña { esPremium = false, fechaReseña = DateTime.Parse("2024-11-01"), puntaje = 5, vino = vino10 },
                //    new Reseña { esPremium = true, fechaReseña = DateTime.Parse("2024-11-05"), puntaje = 4, vino = vino11 }
                //};
                //context.Reseñas.AddRange(reseñasLista);

                //muchos a muchos
                //var book = new Book { Title = "Learning EF Core", Publisher = publisher };
                //book.BookAuthors.Add(new BookAuthor { Book = book, Author = author1 });
                //book.BookAuthors.Add(new BookAuthor { Book = book, Author = author2 });
                //context.Books.Add(book);

                // context.SaveChanges();
            }

            //Pasar lista de vinos a la pantalla
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(listaVinos));

        }
    }
}
