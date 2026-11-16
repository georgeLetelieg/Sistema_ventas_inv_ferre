using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFerreteria.Datos
{
    public static class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            // Lee la cadena de conexión desde el archivo App.config
            string cadena = ConfigurationManager.ConnectionStrings["FerreteriaBD"].ConnectionString;
            return new MySqlConnection(cadena);
        }
    }
}