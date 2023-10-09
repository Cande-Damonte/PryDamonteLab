
namespace PryDamonteLab
{
    partial class FrmMostrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrar));
            this.TreeViewMostrar = new System.Windows.Forms.TreeView();
            this.listMostrar = new System.Windows.Forms.ListView();
            this.ColumnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnUltima = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // TreeViewMostrar
            // 
            this.TreeViewMostrar.ImageIndex = 0;
            this.TreeViewMostrar.ImageList = this.imageList1;
            this.TreeViewMostrar.Location = new System.Drawing.Point(294, 12);
            this.TreeViewMostrar.Name = "TreeViewMostrar";
            this.TreeViewMostrar.SelectedImageIndex = 0;
            this.TreeViewMostrar.Size = new System.Drawing.Size(277, 377);
            this.TreeViewMostrar.TabIndex = 0;
            this.TreeViewMostrar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewMostrar_AfterSelect);
            // 
            // listMostrar
            // 
            this.listMostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnNombre,
            this.ColumnTipo,
            this.ColumnUltima});
            this.listMostrar.HideSelection = false;
            this.listMostrar.Location = new System.Drawing.Point(32, 12);
            this.listMostrar.Name = "listMostrar";
            this.listMostrar.Size = new System.Drawing.Size(256, 377);
            this.listMostrar.TabIndex = 1;
            this.listMostrar.UseCompatibleStateImageBehavior = false;
            this.listMostrar.View = System.Windows.Forms.View.Details;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.Text = "Nombre";
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.Text = "Tipo";
            // 
            // ColumnUltima
            // 
            this.ColumnUltima.Text = "Ultima modificacion";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carpetaicono.jpg");
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.listMostrar);
            this.Controls.Add(this.TreeViewMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewMostrar;
        private System.Windows.Forms.ListView listMostrar;
        private System.Windows.Forms.ColumnHeader ColumnNombre;
        private System.Windows.Forms.ColumnHeader ColumnTipo;
        private System.Windows.Forms.ColumnHeader ColumnUltima;
        private System.Windows.Forms.ImageList imageList1;
    }
}