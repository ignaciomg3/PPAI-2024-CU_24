using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CU_24_GenerarReporte.Entidades;
using DocumentFormat.OpenXml.Bibliography;
using System.Reflection;

namespace CU_24_GenerarReporte.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<RegionVitivinicola> RegionesVitivinicola { get; set; }
        public DbSet<Reseña> Reseñas { get; set; }
        public DbSet<Varietal> Varietales { get; set; }
        public DbSet<Vino> Vinos { get; set; }
        public DbSet<VinoVarietal> VinosVarietales{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la conexión a la base de datos SQLite
            //optionsBuilder.UseSqlite("Data Source=app.sqlite");
            optionsBuilder.UseSqlite(connectionString: "Filename=app.db",
                sqliteOptionsAction: op =>
                {
                    op.MigrationsAssembly(
                        Assembly.GetExecutingAssembly().FullName
                     );
                }
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la relación uno a muchos
            modelBuilder.Entity<Provincia>()
                .HasOne(b => b.pais)
                .WithMany(p => p.provincias)
                .HasForeignKey(b => b.paisId);

            // Configuración de la relación uno a muchos
            modelBuilder.Entity<RegionVitivinicola>()
                .HasOne(b => b.provincia)
                .WithMany(p => p.regiones)
                .HasForeignKey(b => b.provinciaId);

            // Configuración de la relación uno a muchos
            modelBuilder.Entity<Bodega>()
                .HasOne(b => b.region)
                .WithMany(p => p.bodegas)
                .HasForeignKey(b => b.regionVitivinicolaId);

            // Configuración de la relación uno a muchos
            modelBuilder.Entity<Vino>()
                .HasOne(b => b.bodega)
                .WithMany(p => p.vinos)
                .HasForeignKey(b => b.bodegaId);

            // Configuración de la relación uno a muchos
            modelBuilder.Entity<Reseña>()
                .HasOne(b => b.vino)
                .WithMany(p => p.reseñas)
                .HasForeignKey(b => b.vinoId);
            // Configuración de la relación muchos a muchos
            modelBuilder.Entity<VinoVarietal>()
                .HasKey(vv => new { vv.vinoId, vv.varietalId });

            modelBuilder.Entity<VinoVarietal>()
                .HasOne(vv => vv.vino)
                .WithMany(v => v.varietales)
                .HasForeignKey(vv => vv.vinoId);

            modelBuilder.Entity<VinoVarietal>()
                .HasOne(vv => vv.varietal)
                .WithMany(v => v.vinos)
                .HasForeignKey(vv => vv.varietalId);

            base.OnModelCreating(modelBuilder);
            // Configuración adicional de tus entidades, si es necesario
        }
        public void EnsureDatabaseCreated()
        {
            Database.EnsureCreated();
        }
    }
}
