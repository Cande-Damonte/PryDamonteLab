
namespace PryDamonteLab
{
    partial class FrmGrilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrilla));
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumExpe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJuzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJurisd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLiquidador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnVerGrilla = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.AllowUserToAddRows = false;
            this.DgvProveedores.AllowUserToDeleteRows = false;
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnEntidad,
            this.ColumnApertura,
            this.ColumnNumExpe,
            this.ColumnJuzgado,
            this.ColumnJurisd,
            this.ColumnDirec,
            this.ColumnLiquidador});
            this.DgvProveedores.Location = new System.Drawing.Point(12, 12);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            this.DgvProveedores.Size = new System.Drawing.Size(810, 327);
            this.DgvProveedores.TabIndex = 0;
            // 
            // ColumnNum
            // 
            this.ColumnNum.HeaderText = "N°";
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.ReadOnly = true;
            // 
            // ColumnEntidad
            // 
            this.ColumnEntidad.HeaderText = "Entidad";
            this.ColumnEntidad.Name = "ColumnEntidad";
            this.ColumnEntidad.ReadOnly = true;
            // 
            // ColumnApertura
            // 
            this.ColumnApertura.HeaderText = "Apertura";
            this.ColumnApertura.Name = "ColumnApertura";
            this.ColumnApertura.ReadOnly = true;
            // 
            // ColumnNumExpe
            // 
            this.ColumnNumExpe.HeaderText = "N° Expediente";
            this.ColumnNumExpe.Name = "ColumnNumExpe";
            this.ColumnNumExpe.ReadOnly = true;
            // 
            // ColumnJuzgado
            // 
            this.ColumnJuzgado.HeaderText = "Juzgado";
            this.ColumnJuzgado.Name = "ColumnJuzgado";
            this.ColumnJuzgado.ReadOnly = true;
            // 
            // ColumnJurisd
            // 
            this.ColumnJurisd.HeaderText = "Jurisdiccion";
            this.ColumnJurisd.Name = "ColumnJurisd";
            this.ColumnJurisd.ReadOnly = true;
            // 
            // ColumnDirec
            // 
            this.ColumnDirec.HeaderText = "Direccion";
            this.ColumnDirec.Name = "ColumnDirec";
            this.ColumnDirec.ReadOnly = true;
            // 
            // ColumnLiquidador
            // 
            this.ColumnLiquidador.HeaderText = "Liquidador";
            this.ColumnLiquidador.Name = "ColumnLiquidador";
            this.ColumnLiquidador.ReadOnly = true;
            // 
            // BtnVerGrilla
            // 
            this.BtnVerGrilla.Location = new System.Drawing.Point(141, 384);
            this.BtnVerGrilla.Name = "BtnVerGrilla";
            this.BtnVerGrilla.Size = new System.Drawing.Size(127, 37);
            this.BtnVerGrilla.TabIndex = 1;
            this.BtnVerGrilla.Text = "Ver grilla";
            this.BtnVerGrilla.UseVisualStyleBackColor = true;
            this.BtnVerGrilla.Click += new System.EventHandler(this.BtnVerGrilla_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(377, 384);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(127, 37);
            this.BtnCargar.TabIndex = 2;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(592, 384);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(127, 37);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // FrmGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnVerGrilla);
            this.Controls.Add(this.DgvProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grilla de proveedores";
            this.Load += new System.EventHandler(this.FrmGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumExpe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJuzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJurisd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLiquidador;
        private System.Windows.Forms.Button BtnVerGrilla;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnBorrar;
    }
}