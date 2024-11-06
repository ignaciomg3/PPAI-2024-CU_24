namespace CU_24_GenerarReporte.Boundary
{
    partial class PantallaRankingVinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRankingVinos));
            this.btnGenerarRanking = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoReseña = new System.Windows.Forms.ComboBox();
            this.btnGenerarRankingDeVinos = new System.Windows.Forms.Button();
            this.panelGenerarRanking = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupoBoxVisualizacion = new System.Windows.Forms.GroupBox();
            this.rbPantalla = new System.Windows.Forms.RadioButton();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.panelGenerarRanking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grupoBoxVisualizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarRanking
            // 
            this.btnGenerarRanking.Location = new System.Drawing.Point(284, 378);
            this.btnGenerarRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarRanking.Name = "btnGenerarRanking";
            this.btnGenerarRanking.Size = new System.Drawing.Size(131, 33);
            this.btnGenerarRanking.TabIndex = 0;
            this.btnGenerarRanking.Text = "Generar Ranking";
            this.btnGenerarRanking.UseVisualStyleBackColor = true;
            this.btnGenerarRanking.Click += new System.EventHandler(this.btnGenerarRanking_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(73, 38);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(309, 22);
            this.dtpDesde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta: ";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(73, 82);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(309, 22);
            this.dtpHasta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Reseña: ";
            // 
            // cmbTipoReseña
            // 
            this.cmbTipoReseña.FormattingEnabled = true;
            this.cmbTipoReseña.Items.AddRange(new object[] {
            "Sommelier",
            "Normales",
            "Amigos"});
            this.cmbTipoReseña.Location = new System.Drawing.Point(138, 30);
            this.cmbTipoReseña.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoReseña.Name = "cmbTipoReseña";
            this.cmbTipoReseña.Size = new System.Drawing.Size(188, 24);
            this.cmbTipoReseña.TabIndex = 7;
            this.cmbTipoReseña.Tag = "";
            this.cmbTipoReseña.Text = "Sommelier";
            // 
            // btnGenerarRankingDeVinos
            // 
            this.btnGenerarRankingDeVinos.Location = new System.Drawing.Point(16, 15);
            this.btnGenerarRankingDeVinos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarRankingDeVinos.Name = "btnGenerarRankingDeVinos";
            this.btnGenerarRankingDeVinos.Size = new System.Drawing.Size(223, 57);
            this.btnGenerarRankingDeVinos.TabIndex = 12;
            this.btnGenerarRankingDeVinos.Text = "Generar Ranking de Vinos";
            this.btnGenerarRankingDeVinos.UseVisualStyleBackColor = true;
            this.btnGenerarRankingDeVinos.Click += new System.EventHandler(this.btnGenerarRankingDeVinos_Click);
            // 
            // panelGenerarRanking
            // 
            this.panelGenerarRanking.Controls.Add(this.groupBox1);
            this.panelGenerarRanking.Controls.Add(this.btnCancelar);
            this.panelGenerarRanking.Controls.Add(this.grupoBoxVisualizacion);
            this.panelGenerarRanking.Controls.Add(this.btnGenerarRanking);
            this.panelGenerarRanking.Controls.Add(this.label3);
            this.panelGenerarRanking.Controls.Add(this.cmbTipoReseña);
            this.panelGenerarRanking.Location = new System.Drawing.Point(5, 1);
            this.panelGenerarRanking.Margin = new System.Windows.Forms.Padding(4);
            this.panelGenerarRanking.Name = "panelGenerarRanking";
            this.panelGenerarRanking.Size = new System.Drawing.Size(425, 423);
            this.panelGenerarRanking.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(242)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 150);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de Reseñas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 378);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grupoBoxVisualizacion
            // 
            this.grupoBoxVisualizacion.Controls.Add(this.rbPantalla);
            this.grupoBoxVisualizacion.Controls.Add(this.rbExcel);
            this.grupoBoxVisualizacion.Controls.Add(this.rbPDF);
            this.grupoBoxVisualizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(242)))));
            this.grupoBoxVisualizacion.Location = new System.Drawing.Point(11, 235);
            this.grupoBoxVisualizacion.Margin = new System.Windows.Forms.Padding(4);
            this.grupoBoxVisualizacion.Name = "grupoBoxVisualizacion";
            this.grupoBoxVisualizacion.Padding = new System.Windows.Forms.Padding(4);
            this.grupoBoxVisualizacion.Size = new System.Drawing.Size(404, 92);
            this.grupoBoxVisualizacion.TabIndex = 12;
            this.grupoBoxVisualizacion.TabStop = false;
            this.grupoBoxVisualizacion.Text = "Tipo de Visualización";
            // 
            // rbPantalla
            // 
            this.rbPantalla.AutoSize = true;
            this.rbPantalla.Location = new System.Drawing.Point(300, 41);
            this.rbPantalla.Margin = new System.Windows.Forms.Padding(4);
            this.rbPantalla.Name = "rbPantalla";
            this.rbPantalla.Size = new System.Drawing.Size(77, 20);
            this.rbPantalla.TabIndex = 2;
            this.rbPantalla.TabStop = true;
            this.rbPantalla.Text = "Pantalla";
            this.rbPantalla.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(155, 41);
            this.rbExcel.Margin = new System.Windows.Forms.Padding(4);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(61, 20);
            this.rbExcel.TabIndex = 1;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Location = new System.Drawing.Point(8, 41);
            this.rbPDF.Margin = new System.Windows.Forms.Padding(4);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(55, 20);
            this.rbPDF.TabIndex = 0;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // PantallaRankingVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(70)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(444, 438);
            this.Controls.Add(this.panelGenerarRanking);
            this.Controls.Add(this.btnGenerarRankingDeVinos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaRankingVinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Ranking de Vinos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaRankingVinos_FormClosing);
            this.panelGenerarRanking.ResumeLayout(false);
            this.panelGenerarRanking.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupoBoxVisualizacion.ResumeLayout(false);
            this.grupoBoxVisualizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        private void InitializeCustomComponent()
        {

        }
        #endregion

        private System.Windows.Forms.Button btnGenerarRanking;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoReseña;
        private System.Windows.Forms.Button btnGenerarRankingDeVinos;
        private System.Windows.Forms.Panel panelGenerarRanking;
        private System.Windows.Forms.GroupBox grupoBoxVisualizacion;
        private System.Windows.Forms.RadioButton rbPantalla;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}