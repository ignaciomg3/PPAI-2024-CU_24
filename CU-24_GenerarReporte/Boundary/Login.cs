using CU_24_GenerarReporte.Boundary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_24_GenerarReporte
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Hide();
            // Creamos una nueva instancia de PantallaPrincipal
            PantallaPrincipal nuevaVentana = new PantallaPrincipal();

            // Mostramos la nueva ventana
            //nuevaVentana.Show();
        }
    }
}
