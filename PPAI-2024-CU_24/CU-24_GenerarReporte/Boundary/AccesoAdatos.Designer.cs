namespace CU_24_GenerarReporte.Boundary
{
    partial class AccesoAdatos
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(48, 78);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(173, 62);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "traer la tabla";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // dgvPaises
            // 
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Location = new System.Drawing.Point(251, 22);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.Size = new System.Drawing.Size(524, 356);
            this.dgvPaises.TabIndex = 1;
            this.dgvPaises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbTablas
            // 
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Items.AddRange(new object[] {
            "Pais",
            "Provincia",
            "RegionVitivinicola",
            "Vino",
            "Bodega",
            "Varietal",
            "Resena",
            "Usuario",
            "Perfil"});
            this.cmbTablas.Location = new System.Drawing.Point(48, 32);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(173, 21);
            this.cmbTablas.TabIndex = 2;
            // 
            // AccesoAdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.dgvPaises);
            this.Controls.Add(this.btnConectar);
            this.Name = "AccesoAdatos";
            this.Text = "AccesoAdatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.ComboBox cmbTablas;
    }
}