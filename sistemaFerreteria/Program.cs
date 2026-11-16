using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFerreteria.Presentacion;

namespace SistemaFerreteria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin login = new FrmLogin();

            // Si el login es exitoso, iniciamos la aplicación completa con el FrmPrincipal
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal(login.UsuarioAutenticado));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}