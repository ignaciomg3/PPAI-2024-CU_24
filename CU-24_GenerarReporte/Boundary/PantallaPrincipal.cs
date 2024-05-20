using CU_24_GenerarReporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_24_GenerarReporte.Boundary
{
    public partial class PantallaPrincipal : Form
    {
        // Crear perfiles con descripciones
        static Perfil perfilAdmin = new Perfil("Administrador", "Tiene acceso completo a todas las funcionalidades.");
        static Perfil perfilUsuario = new Perfil("Usuario", "Tiene acceso limitado a las funcionalidades.");

        // Crear usuarios con diferentes perfiles
        static Usuario admin = new Usuario("Juan Perez", "juan@example.com", perfilAdmin);
        static Usuario usuario = new Usuario("Maria Gomez", "maria@example.com", perfilUsuario);

        // Crear una certificación
        static Certificacion certificacion = new Certificacion(
            "http://example.com/certificado.pdf",
            "Certificación de experto en C#",
            new DateTime(2024, 12, 31),
            new DateTime(2023, 1, 1),
            "Instituto de Tecnología",
            "Certificación C#"
        );
        // Crear una instancia de TipoUva
        static TipoUva uva = new TipoUva("Cabernet Sauvignon", "Una de las variedades de uva más conocidas en el mundo.");

        // Crear una instancia de CobroPremium - Mensual
        static CobroPremium cobroMensual = new CobroPremium(
            esAnual: false,
            fechaPago: new DateTime(2024, 5, 17),
            monto: 500.00m,
            nroOperacionMercadoPago: "MP1234567890"
        );

        // Crear una instancia de CobroPremium - Anual
        static CobroPremium cobroAnual = new CobroPremium(
            esAnual: true,
            fechaPago: new DateTime(2024, 1, 1),
            monto: 5000.00m,
            nroOperacionMercadoPago: "MP0987654321"
        );
        // Crear instancias de TipoUva
        static TipoUva cabernetSauvignon = new TipoUva("Cabernet Sauvignon", "Una de las variedades de uva más conocidas en el mundo.");
        static TipoUva merlot = new TipoUva("Merlot", "Una variedad de uva tinta utilizada para elaborar vino.");

        // Crear instancias de Varietal
        static Varietal varietal1 = new Varietal("Vino Tinto", 75.5, cabernetSauvignon);
        static Varietal varietal2 = new Varietal("Vino Blanco", 24.5, merlot);

        // Crear instancias de Maridaje
        static Maridaje queso = new Maridaje("Queso", "Marida bien con vinos tintos y blancos.");
        static Maridaje carne = new Maridaje("Carne", "Ideal para acompañar con vinos tintos robustos.");
        static Maridaje pescado = new Maridaje("Pescado", "Perfecto para vinos blancos y rosados.");

        // Crear instancias de RegionVitivinicola
        static RegionVitivinicola region1 = new RegionVitivinicola("Valle de Napa", "Famosa por sus vinos tintos de alta calidad.");
        static RegionVitivinicola region2 = new RegionVitivinicola("Valle de Casablanca", "Conocida por sus vinos blancos frescos y aromáticos.");

        // Crear instancias de Provincias
        static Provincia provincia1 = new Provincia("Mendoza");
        static Provincia provincia2 = new Provincia("Santiago del Estero");
        static Provincia provincia3 = new Provincia("San Juan");
        static Provincia provincia4 = new Provincia("La Rioja");

        // Crear una instancia de País
        static Pais pais = new Pais("Argentina");



        
        
        public PantallaPrincipal()
        {
            InitializeComponent();

            // Mostrar la institución otorgante
            certificacion.MostrarInstitucion();

            // Mostrar la información de ambos cobros
            Console.WriteLine("Cobro Mensual:");
            cobroMensual.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Cobro Anual:");
            cobroAnual.MostrarInformacion();

            // Mostrar información de varietal1
            Console.WriteLine("Varietal 1:");
            varietal1.TipoUva.MostrarInformacion();
            varietal1.MostrarPorcentaje();
            Console.WriteLine();

            // Mostrar información de varietal2
            Console.WriteLine("Varietal 2:");
            varietal2.TipoUva.MostrarInformacion();
            varietal2.MostrarPorcentaje();

            //Mostar Maridajes
            Console.WriteLine("Maridajes:");
            queso.MostrarInformacion();
            carne.MostrarInformacion();
            pescado.MostrarInformacion();

            // Mostrar información de las regiones vitivinícolas
            Console.WriteLine("Región 1:");
            region1.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Región 2:");
            region2.MostrarInformacion();

            provincia1.Regiones.Add(region1);
            provincia2.Regiones.Add(region2);

            // Agregar provincias al país
            pais.Provincias.Add(provincia1);
            pais.Provincias.Add(provincia2);
            pais.Provincias.Add(provincia3);
            pais.Provincias.Add(provincia4);

            // Mostrar información del país
            Console.WriteLine($"País: {pais.Nombre}");
            Console.WriteLine($"Cantidad de Provincias: {pais.ContarProvincias()}");
            Console.WriteLine($"Cantidad de Bodegas: {pais.ContarBodegas()}");
            Console.WriteLine("Provincias:");
            pais.MostrarProvincias();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
