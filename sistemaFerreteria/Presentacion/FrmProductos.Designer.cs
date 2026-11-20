using System.Windows.Forms;

namespace SistemaFerreteria.Presentacion
{
    // Es vital heredar de Form aquí para que Visual Studio reconozca los controles
    partial class FrmProductos : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.CheckBox chkDespacho;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbComunes;
        private System.Windows.Forms.GroupBox gbEspecificos;
        private System.Windows.Forms.Label lblCodigo, lblNombre, lblPrecio, lblStock, lblTipo, lblMarca, lblGarantia, lblUnidad;

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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.chkDespacho = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbComunes = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.gbEspecificos = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbComunes.SuspendLayout();
            this.gbEspecificos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(760, 200);
            this.dgvProductos.TabIndex = 2;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Items.AddRange(new object[] {
            "HERRAMIENTA",
            "MATERIAL"});
            this.cmbTipo.Location = new System.Drawing.Point(100, 27);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 28);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(100, 117);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(100, 147);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 26);
            this.txtStock.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(100, 27);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 26);
            this.txtMarca.TabIndex = 1;
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(100, 57);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(100, 26);
            this.txtGarantia.TabIndex = 3;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(100, 87);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(100, 26);
            this.txtUnidadMedida.TabIndex = 5;
            // 
            // chkDespacho
            // 
            this.chkDespacho.Location = new System.Drawing.Point(220, 89);
            this.chkDespacho.Name = "chkDespacho";
            this.chkDespacho.Size = new System.Drawing.Size(104, 24);
            this.chkDespacho.TabIndex = 6;
            this.chkDespacho.Text = "Req. Despacho";
            // 
            // btnGuardar
            // 
            // Botón Editar
            this.btnEditar.Location = new System.Drawing.Point(530, 360);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 40);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // Botón Eliminar
            this.btnEliminar.Location = new System.Drawing.Point(650, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 40);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // Botón Limpiar (opcional, debajo de btnGuardar o al lado)
            this.btnLimpiar.Location = new System.Drawing.Point(290, 360);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 40);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnGuardar.Location = new System.Drawing.Point(400, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Agregar Producto";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbComunes
            // 
            this.gbComunes.Controls.Add(this.lblTipo);
            this.gbComunes.Controls.Add(this.cmbTipo);
            this.gbComunes.Controls.Add(this.lblCodigo);
            this.gbComunes.Controls.Add(this.txtCodigo);
            this.gbComunes.Controls.Add(this.lblNombre);
            this.gbComunes.Controls.Add(this.txtNombre);
            this.gbComunes.Controls.Add(this.lblPrecio);
            this.gbComunes.Controls.Add(this.txtPrecio);
            this.gbComunes.Controls.Add(this.lblStock);
            this.gbComunes.Controls.Add(this.txtStock);
            this.gbComunes.Location = new System.Drawing.Point(12, 220);
            this.gbComunes.Name = "gbComunes";
            this.gbComunes.Size = new System.Drawing.Size(370, 180);
            this.gbComunes.TabIndex = 1;
            this.gbComunes.TabStop = false;
            this.gbComunes.Text = "Datos Generales";
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(15, 30);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(79, 23);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(15, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(79, 23);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(15, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 23);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(15, 120);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 23);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio Neto:";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(15, 150);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(79, 23);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            // 
            // gbEspecificos
            // 
            this.gbEspecificos.Controls.Add(this.lblMarca);
            this.gbEspecificos.Controls.Add(this.txtMarca);
            this.gbEspecificos.Controls.Add(this.lblGarantia);
            this.gbEspecificos.Controls.Add(this.txtGarantia);
            this.gbEspecificos.Controls.Add(this.lblUnidad);
            this.gbEspecificos.Controls.Add(this.txtUnidadMedida);
            this.gbEspecificos.Controls.Add(this.chkDespacho);
            this.gbEspecificos.Location = new System.Drawing.Point(400, 220);
            this.gbEspecificos.Name = "gbEspecificos";
            this.gbEspecificos.Size = new System.Drawing.Size(370, 130);
            this.gbEspecificos.TabIndex = 0;
            this.gbEspecificos.TabStop = false;
            this.gbEspecificos.Text = "Atributos Específicos";
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(15, 30);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(79, 23);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // lblGarantia
            // 
            this.lblGarantia.Location = new System.Drawing.Point(15, 60);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(79, 23);
            this.lblGarantia.TabIndex = 2;
            this.lblGarantia.Text = "Garantía (Meses):";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Location = new System.Drawing.Point(15, 90);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(79, 23);
            this.lblUnidad.TabIndex = 4;
            this.lblUnidad.Text = "U. Medida:";
            // 
            // FrmProductos
            // 
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.gbEspecificos);
            this.Controls.Add(this.gbComunes);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "FrmProductos";
            this.Text = "Mantenedor de Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbComunes.ResumeLayout(false);
            this.gbComunes.PerformLayout();
            this.gbEspecificos.ResumeLayout(false);
            this.gbEspecificos.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}