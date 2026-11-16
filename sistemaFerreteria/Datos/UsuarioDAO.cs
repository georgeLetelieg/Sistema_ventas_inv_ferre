using MySql.Data.MySqlClient;
using SistemaFerreteria.Modelo;
using SistemaFerreteria.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFerreteria.Datos
{
    public class UsuarioDAO
    {
        public Usuario Autenticar(string username, string passwordClara)
        {
            Usuario usuario = null;

            // Encriptamos la contraseña digitada para compararla con la BD
            string hashCalculado = Seguridad.CalcularHash(passwordClara);

            // Consulta parametrizada obligatoria
            string sql = "SELECT id, username, password_hash, rol FROM usuarios WHERE username = @user AND password_hash = @pass";

            using (MySqlConnection cn = Conexion.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", hashCalculado);

                cn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            Id = reader.GetInt32("id"),
                            Username = reader.GetString("username"),
                            PasswordHash = reader.GetString("password_hash"),
                            Rol = reader.GetString("rol")
                        };
                    }
                }
            }
            return usuario; // Si las credenciales son incorrectas, retornará null
        }
    }
}
