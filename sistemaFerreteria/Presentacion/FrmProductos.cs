using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaFerreteria.Datos;
using SistemaFerreteria.Modelo;

namespace SistemaFerreteria.Presentacion
{
    public partial class FrmProductos : Form
    {
        private ProductoDAO _dao;

        public FrmProductos()
        {
            InitializeComponent();
            _dao = new ProductoDAO();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0; // Selecciona "HERRAMIENTA" por defecto
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                // Operación Listar del Grupo B
                List<Producto> lista = _dao.ObtenerTodos();
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ocultar/Mostrar campos según el tipo seleccionado
            bool esHerramienta = (cmbTipo.SelectedItem.ToString() == "HERRAMIENTA");

            txtMarca.Enabled = esHerramienta;
            txtGarantia.Enabled = esHerramienta;

            txtUnidadMedida.Enabled = !esHerramienta;
            chkDespacho.Enabled = !esHerramienta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas de formato
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Código y Nombre son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);

                Producto nuevoProducto;

                // Instanciación de clase derivada según la selección
                if (cmbTipo.SelectedItem.ToString() == "HERRAMIENTA")
                {
                    nuevoProducto = new Herramienta
                    {
                        Codigo = txtCodigo.Text,
                        Nombre = txtNombre.Text,
                        PrecioNeto = precio,
                        Stock = stock,
                        Marca = txtMarca.Text,
                        MesesGarantia = string.IsNullOrWhiteSpace(txtGarantia.Text) ? 0 : Convert.ToInt32(txtGarantia.Text)
                    };
                }
                else
                {
                    nuevoProducto = new Material
                    {
                        Codigo = txtCodigo.Text,
                        Nombre = txtNombre.Text,
                        PrecioNeto = precio,
                        Stock = stock,
                        UnidadMedida = txtUnidadMedida.Text,
                        RequiereDespacho = chkDespacho.Checked
                    };
                }

                // Operación Agregar del Grupo B
                _dao.Insertar(nuevoProducto);
                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla(); // Refresca la tabla
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar valores numéricos válidos en Precio, Stock y Garantía.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex) // Captura las validaciones de los setters de las clases de Modelo
            {
                MessageBox.Show(ex.Message, "Datos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Al hacer clic en una fila de la grilla, carga los datos en las cajas de texto
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Producto seleccionado = dgvProductos.Rows[e.RowIndex].DataBoundItem as Producto;
            if (seleccionado == null) return;

            txtCodigo.Text = seleccionado.Codigo;
            txtCodigo.Enabled = false; // Se bloquea el código porque es la clave para editar/eliminar
            txtNombre.Text = seleccionado.Nombre;
            txtPrecio.Text = seleccionado.PrecioNeto.ToString();
            txtStock.Text = seleccionado.Stock.ToString();

            if (seleccionado is Herramienta h)
            {
                cmbTipo.SelectedItem = "HERRAMIENTA";
                txtMarca.Text = h.Marca;
                txtGarantia.Text = h.MesesGarantia.ToString();
            }
            else if (seleccionado is Material m)
            {
                cmbTipo.SelectedItem = "MATERIAL";
                txtUnidadMedida.Text = m.UnidadMedida;
                chkDespacho.Checked = m.RequiereDespacho;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecciona primero un producto de la tabla para editar.", "Aviso");
                return;
            }

            try
            {
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);
                Producto prod;

                if (cmbTipo.SelectedItem.ToString() == "HERRAMIENTA")
                {
                    prod = new Herramienta
                    {
                        Codigo = txtCodigo.Text,
                        Nombre = txtNombre.Text,
                        PrecioNeto = precio,
                        Stock = stock,
                        Marca = txtMarca.Text,
                        MesesGarantia = int.Parse(txtGarantia.Text)
                    };
                }
                else
                {
                    prod = new Material
                    {
                        Codigo = txtCodigo.Text,
                        Nombre = txtNombre.Text,
                        PrecioNeto = precio,
                        Stock = stock,
                        UnidadMedida = txtUnidadMedida.Text,
                        RequiereDespacho = chkDespacho.Checked
                    };
                }

                if (_dao.Actualizar(prod))
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito");
                    CargarGrilla(); // Usa el nombre exacto de tu método que recarga la grilla
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecciona primero un producto de la tabla para eliminar.", "Aviso");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que deseas eliminar el producto {txtCodigo.Text}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    if (_dao.Eliminar(txtCodigo.Text))
                    {
                        MessageBox.Show("Producto eliminado.", "Éxito");
                        CargarGrilla(); // Usa el nombre exacto de tu método que recarga la grilla
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar (puede estar asociado a una venta): " + ex.Message, "Error");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Enabled = true;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtMarca.Clear();
            txtGarantia.Clear();
            txtUnidadMedida.Clear();
            chkDespacho.Checked = false;
            txtCodigo.Focus();
        }
    }
}