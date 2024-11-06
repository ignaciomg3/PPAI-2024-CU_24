using CU_24_GenerarReporte.Controlador;
using CU_24_GenerarReporte.Entidades;
using CU_24_GenerarReporte.Interfaces;
using CU_24_GenerarReporte.Objetos;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CU_24_GenerarReporte.Boundary
{
    public partial class PantallaRankingVinos : Form
    {
        private GestorRankingVinos gestorAtributo;


        public PantallaRankingVinos(List<Vino> listaVinos)
        {
            InitializeComponent();

            //Inicio de pantalla
            panelGenerarRanking.Visible = false;
            rbExcel.Checked = true;
            gestorAtributo = new GestorRankingVinos(listaVinos, this, new ReporteReseñaSommelier(), new VisualizacionExcel());
            rbExcel.Checked = true;
            this.Width = 207;
            this.Height = 126;
            this.CenterToScreen();
        }

        //Boton de pantalla anterior
        private void btnGenerarRankingDeVinos_Click(object sender, EventArgs e)
        {
            opcionGenerarRankingDeVinos();
        }
        
        //Inicio de CU
        private void btnGenerarRanking_Click(object sender, EventArgs e)
        {
            //Cuando hace click para generar el reporte:
            gestorAtributo.opcionGenerarRankingVinos(); //este método no sé que función cumple.
        }

        private void opcionGenerarRankingDeVinos()
        {
            habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            panelGenerarRanking.Visible = true;
            btnGenerarRankingDeVinos.Hide();
            this.Width = 352;
            this.Height = 397;
            this.CenterToScreen();
        }

        public void solicitarSelFechaDesdeYHasta()
        {
            DateTime desde = tomarSelFechaDesde();
            DateTime hasta = tomarSelFechaHasta();
             
            if (validarPeriodo(desde,hasta))
            {
                //si es válido..
                gestorAtributo.tomarSelFechaDesdeYHasta(desde,hasta);
            }
            else
            {
                MessageBox.Show("El periodo no es válido. La fecha 'Desde' debe ser menor o igual a la fecha 'Hasta'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            
        }

        public DateTime tomarSelFechaDesde()
        {
            return dtpDesde.Value;
        }
        public DateTime tomarSelFechaHasta()
        {
            return dtpHasta.Value;
        }

        public bool validarPeriodo(DateTime desde, DateTime hasta)
        {
             
            if (desde <= hasta)
            {
                return true;
            }
            return false ;
        }

        public void solicitarSelTipoReseña()
        {
            string tipoReseña =  tomarSelTipoReseña();
            gestorAtributo.tomarSelTipoReseña(tipoReseña);
        }
     
        public string tomarSelTipoReseña()
        {
            return cmbTipoReseña.SelectedItem.ToString();

        }
        public void solicitarSelTipoVisualizacion()
        {
            string tipoVisualizacion = tomarSelTipoVisualizacion();

            gestorAtributo.tomarSelTipoVisualizacion(tipoVisualizacion);
        }
        private string tomarSelTipoVisualizacion()
        {
            if (rbPDF.Checked)
            {
                return "PDF";
            }
            else if (rbExcel.Checked)
            {
                return "Excel";
            }
            else if (rbPantalla.Checked)
            {
                return "Pantalla";
            }
            else
            {
                return null; // Ningún RadioButton está seleccionado
            }
        }

        public void solicitarConfirmacionGenReporte()
        {

            if (tomarConfirmacionGenReporte())
            {
                // Código para generar el reporte
                gestorAtributo.tomarConfirmacionGenReporte();
            }
            else
            {
                // Código si el usuario cancela la generación del reporte
                //Alternativo 1
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool tomarConfirmacionGenReporte()
        {
            DialogResult result = MessageBox.Show("¿Desea Generar el Reporte con estos datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public void confirmarExportacion(bool rankingCreado)
        {
            if (rankingCreado)
            {
                MessageBox.Show("El Archivo ha sido generado con exito!");
            }
            else
            {
                MessageBox.Show("El Archivo no se ha podido generar correctamente.");
            }
        }

        //Caso Alternativo
        public void noHayReseñasSommelier()
        {
            MessageBox.Show("No se encontraron Reseñas de Sommelier en el periodo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panelGenerarRanking.Visible = false;
                btnGenerarRankingDeVinos.Show();
                this.Width = 207;
                this.Height = 126;
                this.CenterToScreen();

            }

        }

        private void PantallaRankingVinos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
