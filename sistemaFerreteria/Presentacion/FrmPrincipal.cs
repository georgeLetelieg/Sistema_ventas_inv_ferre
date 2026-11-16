using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFerreteria.Modelo;


namespace SistemaFerreteria.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private Usuario _usuarioActual;

        // El constructor recibe al usuario que inició sesión desde FrmLogin
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            ConfigurarSesion();
        }

        private void ConfigurarSesion()
        {
            // Muestra quién está usando el sistema en la barra inferior
            lblUsuarioActivo.Text = $"Usuario: {_usuarioActual.Username} | Rol: {_usuarioActual.Rol}";

            // Control de Permisos (Si no es Administrador, no ve el menú de Mantenedores)
            if (_usuarioActual.Rol != "Administrador")
            {
                menuMantenedores.Visible = false;
            }
        }

        // Método para abrir ventanas internas sin que se dupliquen
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form abierto = this.MdiChildren.FirstOrDefault(f => f is T);
            if (abierto != null)
            {
                abierto.Activate(); // Si ya está abierta, la trae al frente
                return;
            }
            T frm = new T { MdiParent = this };
            frm.Show();
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra todo el programa
        }

        private void itemProductos_Click(object sender, EventArgs e)
        {
            // Abre la ventana de productos. 
            // Nota: Si aún no creas el archivo FrmProductos.cs, comenta esta línea temporalmente para que compile.
            AbrirFormulario<FrmProductos>();
        }

        // Métodos de organización visual de las ventanas internas (MDI)
        private void itemCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void itemMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void itemMosaicoVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}