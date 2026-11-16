namespace SistemaFerreteria.Presentacion
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.ToolStripMenuItem menuMantenedores;
        private System.Windows.Forms.ToolStripMenuItem itemProductos;
        private System.Windows.Forms.ToolStripMenuItem menuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem itemVentas;
        private System.Windows.Forms.ToolStripMenuItem menuVentana;
        private System.Windows.Forms.ToolStripMenuItem itemCascada;
        private System.Windows.Forms.ToolStripMenuItem itemMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem itemMosaicoVertical;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioActivo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMantenedores = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioActivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // menuPrincipal
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuMantenedores,
            this.menuOperaciones,
            this.menuVentana});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";

            // menuArchivo
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.itemSalir });
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";

            // itemSalir
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(96, 22);
            this.itemSalir.Text = "Salir";
            this.itemSalir.Click += new System.EventHandler(this.itemSalir_Click);

            // menuMantenedores
            this.menuMantenedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.itemProductos });
            this.menuMantenedores.Name = "menuMantenedores";
            this.menuMantenedores.Size = new System.Drawing.Size(95, 20);
            this.menuMantenedores.Text = "Mantenedores";

            // itemProductos
            this.itemProductos.Name = "itemProductos";
            this.itemProductos.Size = new System.Drawing.Size(128, 22);
            this.itemProductos.Text = "Productos";
            this.itemProductos.Click += new System.EventHandler(this.itemProductos_Click);

            // menuOperaciones
            this.menuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.itemVentas });
            this.menuOperaciones.Name = "menuOperaciones";
            this.menuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.menuOperaciones.Text = "Operaciones";

            // itemVentas
            this.itemVentas.Name = "itemVentas";
            this.itemVentas.Size = new System.Drawing.Size(108, 22);
            this.itemVentas.Text = "Ventas";
            // TODO: Agregar evento click cuando creemos FrmVentas

            // menuVentana
            this.menuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCascada,
            this.itemMosaicoHorizontal,
            this.itemMosaicoVertical});
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(61, 20);
            this.menuVentana.Text = "Ventana";

            // itemCascada
            this.itemCascada.Name = "itemCascada";
            this.itemCascada.Size = new System.Drawing.Size(177, 22);
            this.itemCascada.Text = "Cascada";
            this.itemCascada.Click += new System.EventHandler(this.itemCascada_Click);

            // itemMosaicoHorizontal
            this.itemMosaicoHorizontal.Name = "itemMosaicoHorizontal";
            this.itemMosaicoHorizontal.Size = new System.Drawing.Size(177, 22);
            this.itemMosaicoHorizontal.Text = "Mosaico Horizontal";
            this.itemMosaicoHorizontal.Click += new System.EventHandler(this.itemMosaicoHorizontal_Click);

            // itemMosaicoVertical
            this.itemMosaicoVertical.Name = "itemMosaicoVertical";
            this.itemMosaicoVertical.Size = new System.Drawing.Size(177, 22);
            this.itemMosaicoVertical.Text = "Mosaico Vertical";
            this.itemMosaicoVertical.Click += new System.EventHandler(this.itemMosaicoVertical_Click);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblUsuarioActivo });
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";

            // lblUsuarioActivo
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(86, 17);
            this.lblUsuarioActivo.Text = "Usuario: Ninguno";

            // FrmPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true; // REQUISITO: Contenedor MDI
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ferretería";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}