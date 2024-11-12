using CU_24_GenerarReporte.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using System.Drawing;
using Syncfusion.Pdf.Graphics;

namespace CU_24_GenerarReporte.Objetos
{
    public class VisualizacionPDF:IEstrategiaVisualizacion
    {
        public bool visualizarRanking(List<List<string>> listaOrdenada)
        {
            return exportarPDF(listaOrdenada);
        }
        public bool exportarPDF(List<List<string>> listaOrdenada)
        {
            //Creamos un documento pdf vacio
            PdfDocument doc = new PdfDocument();
            PdfPage page = doc.Pages.Add();
            PdfGrid pdfGrid = new PdfGrid();
            PdfGraphics graphics = page.Graphics;

            string esc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "PDF Files | *.pdf";

            //Creamos una DataTable para pasarle los datos al pdf, funciona igual que un DataGridView.
            //Ponemos los datos como string porque asi los tenemos guardados en la listaOrdenada.
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[8]
            {
                new DataColumn("Puesto", typeof(int)),
                new DataColumn("Nombre", typeof(string)),
                new DataColumn("Puntuacion",typeof(double)),
                new DataColumn("Precio",typeof(string)),
                new DataColumn("Bodega",typeof(string)),
                new DataColumn("Region",typeof(string)),
                new DataColumn("Varietal",typeof(string)),
                new DataColumn("Pais",typeof(string)),
            });

            int puesto = 0;

            foreach (var datosVino in listaOrdenada)
            {
                puesto++;
                // Asegúrate de que cada sublista tenga la cantidad correcta de elementos
                if (datosVino.Count <= 7)
                {
                    // Agregar una nueva fila al DataTable con los datos del vino
                    //                    nombre            puntajesom                     precio          bodega       varietal      region         pais
                    dt.Rows.Add(puesto, datosVino[0], Convert.ToDouble(datosVino[6]), "$" + datosVino[1], datosVino[2], datosVino[3], datosVino[5], datosVino[4]);

                }
            }

            //Cargamos los datos al pdf

            //Cabecera
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            graphics.DrawString("Ranking de Vinos", font, PdfBrushes.Black, new PointF(10, 0));

            //Tabla
            pdfGrid.DataSource = dt;
            pdfGrid.Draw(page, new PointF(10, 40));

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                doc.Save(file.FileName);
                doc.Close(true);
                return true;
            }
            else
            {
                return false;
            }

            //En el caso que queramos que se genere el archivo en un lugar predeterminado con un nombre predeterminado
            //usariamos este codigo por ejemplo
            //doc.SaveAs("C:\User\Documentos\rankingVinos.pdf")
        }
    }
}
