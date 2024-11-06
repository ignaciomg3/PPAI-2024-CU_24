using CU_24_GenerarReporte.Datos;
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
    public partial class AccesoAdatos : Form
    {
        public AccesoAdatos()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //crear un gestorBD
            GestorBD gestorBD = new GestorBD();
            //obtener los paises
            string tablaAobtener = cmbTablas.Text;
            DataTable tabla = gestorBD.obtener_Tabla(tablaAobtener);
            //mostrar los paises en el datagridview
            dgvPaises.DataSource = tabla;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
