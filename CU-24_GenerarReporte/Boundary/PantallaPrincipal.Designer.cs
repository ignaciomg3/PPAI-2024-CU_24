namespace CU_24_GenerarReporte.Boundary
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.btnGenerarRanking = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Región = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoReseña = new System.Windows.Forms.ComboBox();
            this.btnPantalla = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnGenerarRankingDeVinos = new System.Windows.Forms.Button();
            this.panelGenerarRanking = new System.Windows.Forms.Panel();
            this.grupoBoxVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbPantalla = new System.Windows.Forms.RadioButton();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelGenerarRanking.SuspendLayout();
            this.grupoBoxVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarRanking
            // 
            this.btnGenerarRanking.Location = new System.Drawing.Point(459, 178);
            this.btnGenerarRanking.Name = "btnGenerarRanking";
            this.btnGenerarRanking.Size = new System.Drawing.Size(128, 40);
            this.btnGenerarRanking.TabIndex = 0;
            this.btnGenerarRanking.Text = "Generar Ranking";
            this.btnGenerarRanking.UseVisualStyleBackColor = true;
            this.btnGenerarRanking.Click += new System.EventHandler(this.btnGenerarRanking_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Puesto,
            this.Nombre,
            this.Variedad,
            this.Región,
            this.Provincia,
            this.País});
            this.dataGridView1.Location = new System.Drawing.Point(59, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(634, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Variedad
            // 
            this.Variedad.HeaderText = "Variedad";
            this.Variedad.MinimumWidth = 6;
            this.Variedad.Name = "Variedad";
            this.Variedad.Width = 125;
            // 
            // Región
            // 
            this.Región.HeaderText = "Región";
            this.Región.MinimumWidth = 6;
            this.Región.Name = "Región";
            this.Región.Width = 125;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 6;
            this.Provincia.Name = "Provincia";
            this.Provincia.Width = 125;
            // 
            // País
            // 
            this.País.HeaderText = "País";
            this.País.MinimumWidth = 6;
            this.País.Name = "País";
            this.País.Width = 125;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(202, 26);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(233, 20);
            this.dtpDesde.TabIndex = 2;
            this.dtpDesde.Value = new System.DateTime(2024, 5, 8, 1, 21, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta: ";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(202, 62);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(233, 20);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.Value = new System.DateTime(2024, 5, 11, 1, 21, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Reseña: ";
            // 
            // cmbTipoReseña
            // 
            this.cmbTipoReseña.FormattingEnabled = true;
            this.cmbTipoReseña.Items.AddRange(new object[] {
            "Sommelier",
            "Enófilo",
            "Administrador",
            ""});
            this.cmbTipoReseña.Location = new System.Drawing.Point(202, 108);
            this.cmbTipoReseña.Name = "cmbTipoReseña";
            this.cmbTipoReseña.Size = new System.Drawing.Size(142, 21);
            this.cmbTipoReseña.TabIndex = 7;
            this.cmbTipoReseña.Tag = "";
            this.cmbTipoReseña.Text = "Sommelier";
            // 
            // btnPantalla
            // 
            this.btnPantalla.Image = global::CU_24_GenerarReporte.Properties.Resources.img_pantalla;
            this.btnPantalla.Location = new System.Drawing.Point(841, 189);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(77, 74);
            this.btnPantalla.TabIndex = 10;
            this.btnPantalla.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::CU_24_GenerarReporte.Properties.Resources.img_excel;
            this.btnExcel.Location = new System.Drawing.Point(841, 97);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 74);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.Image = global::CU_24_GenerarReporte.Properties.Resources.img_pdf;
            this.btnPDF.Location = new System.Drawing.Point(841, 17);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(76, 74);
            this.btnPDF.TabIndex = 8;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnGenerarRankingDeVinos
            // 
            this.btnGenerarRankingDeVinos.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarRankingDeVinos.Name = "btnGenerarRankingDeVinos";
            this.btnGenerarRankingDeVinos.Size = new System.Drawing.Size(167, 46);
            this.btnGenerarRankingDeVinos.TabIndex = 12;
            this.btnGenerarRankingDeVinos.Text = "Opcion Generar Ranking de Vinos";
            this.btnGenerarRankingDeVinos.UseVisualStyleBackColor = true;
            this.btnGenerarRankingDeVinos.Click += new System.EventHandler(this.btnGenerarRankingDeVinos_Click);
            // 
            // panelGenerarRanking
            // 
            this.panelGenerarRanking.Controls.Add(this.grupoBoxVisualizacion);
            this.panelGenerarRanking.Controls.Add(this.dtpHasta);
            this.panelGenerarRanking.Controls.Add(this.dtpDesde);
            this.panelGenerarRanking.Controls.Add(this.btnGenerarRanking);
            this.panelGenerarRanking.Controls.Add(this.dataGridView1);
            this.panelGenerarRanking.Controls.Add(this.label1);
            this.panelGenerarRanking.Controls.Add(this.btnPantalla);
            this.panelGenerarRanking.Controls.Add(this.label2);
            this.panelGenerarRanking.Controls.Add(this.btnExcel);
            this.panelGenerarRanking.Controls.Add(this.label3);
            this.panelGenerarRanking.Controls.Add(this.btnPDF);
            this.panelGenerarRanking.Controls.Add(this.cmbTipoReseña);
            this.panelGenerarRanking.Location = new System.Drawing.Point(24, 64);
            this.panelGenerarRanking.Name = "panelGenerarRanking";
            this.panelGenerarRanking.Size = new System.Drawing.Size(920, 454);
            this.panelGenerarRanking.TabIndex = 13;
            // 
            // grupoBoxVisualizacion
            // 
            this.grupoBoxVisualizacion.Controls.Add(this.rbPantalla);
            this.grupoBoxVisualizacion.Controls.Add(this.rbExcel);
            this.grupoBoxVisualizacion.Controls.Add(this.rbPDF);
            this.grupoBoxVisualizacion.Location = new System.Drawing.Point(77, 156);
            this.grupoBoxVisualizacion.Name = "grupoBoxVisualizacion";
            this.grupoBoxVisualizacion.Size = new System.Drawing.Size(303, 78);
            this.grupoBoxVisualizacion.TabIndex = 12;
            this.grupoBoxVisualizacion.TabStop = false;
            this.grupoBoxVisualizacion.Text = "Tipo de Visualización";
            // 
            // rbPantalla
            // 
            this.rbPantalla.AutoSize = true;
            this.rbPantalla.Location = new System.Drawing.Point(225, 33);
            this.rbPantalla.Name = "rbPantalla";
            this.rbPantalla.Size = new System.Drawing.Size(63, 17);
            this.rbPantalla.TabIndex = 2;
            this.rbPantalla.TabStop = true;
            this.rbPantalla.Text = "Pantalla";
            this.rbPantalla.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(116, 33);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(51, 17);
            this.rbExcel.TabIndex = 1;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            this.rbExcel.CheckedChanged += new System.EventHandler(this.rbExcel_CheckedChanged);
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Location = new System.Drawing.Point(6, 33);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(46, 17);
            this.rbPDF.TabIndex = 0;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1028, 530);
            this.Controls.Add(this.panelGenerarRanking);
            this.Controls.Add(this.btnGenerarRankingDeVinos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelGenerarRanking.ResumeLayout(false);
            this.panelGenerarRanking.PerformLayout();
            this.grupoBoxVisualizacion.ResumeLayout(false);
            this.grupoBoxVisualizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        private void InitializeCustomComponent()
        {

        }
        #endregion

        private System.Windows.Forms.Button btnGenerarRanking;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Región;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoReseña;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPantalla;
        private System.Windows.Forms.Button btnGenerarRankingDeVinos;
        private System.Windows.Forms.Panel panelGenerarRanking;
        private System.Windows.Forms.GroupBox grupoBoxVisualizacion;
        private System.Windows.Forms.RadioButton rbPantalla;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbPDF;
    }
}