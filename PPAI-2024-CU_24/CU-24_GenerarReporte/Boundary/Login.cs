using CU_24_GenerarReporte.Boundary;
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

namespace CU_24_GenerarReporte
{
    public partial class Login : Form
    {
        //Atributo para pasar la lista de vinos
        public List<Vino> listaVinos { get; set; }

        public Login(List<Vino> listaVinos)
        {
            InitializeComponent();
            this.listaVinos = listaVinos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PantallaRankingVinos pantallaPrincipal = new PantallaRankingVinos(listaVinos);
            pantallaPrincipal.Show();
            this.Hide();
        }

    }
}
