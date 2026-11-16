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
    public partial class FrmLogin : Form
    {
        public Usuario UsuarioAutenticado { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuarioDAO dao = new UsuarioDAO();
                Usuario usuario = dao.Autenticar(txtUsuario.Text, txtPassword.Text);

                if (usuario != null)
                {
                    UsuarioAutenticado = usuario;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}