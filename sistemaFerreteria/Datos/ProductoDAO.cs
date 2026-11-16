using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using SistemaFerreteria.Modelo;

namespace SistemaFerreteria.Datos
{
    public class ProductoDAO
    {
        // Operación 1: Listar (Retorna una colección List<T> exigida en la rúbrica)
        public List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();
            string sql = "SELECT id, codigo, nombre, precio_neto, stock, tipo, marca, meses_garantia, unidad_medida, requiere_despacho FROM productos";

            using (MySqlConnection cn = Conexion.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(sql, cn))
            {
                cn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tipo = reader.GetString("tipo");
                        Producto p;

                        // Aplicamos la lógica de herencia según el tipo en la BD
                        if (tipo == "HERRAMIENTA")
                        {
                            p = new Herramienta
                            {
                                Marca = reader.IsDBNull(reader.GetOrdinal("marca")) ? null : reader.GetString("marca"),
                                MesesGarantia = reader.IsDBNull(reader.GetOrdinal("meses_garantia")) ? 0 : reader.GetInt32("meses_garantia")
                            };
                        }
                        else // Es MATERIAL
                        {
                            p = new Material
                            {
                                UnidadMedida = reader.IsDBNull(reader.GetOrdinal("unidad_medida")) ? null : reader.GetString("unidad_medida"),
                                RequiereDespacho = !reader.IsDBNull(reader.GetOrdinal("requiere_despacho")) && reader.GetBoolean("requiere_despacho")
                            };
                        }

                        // Propiedades comunes de la clase base
                        p.Id = reader.GetInt32("id");
                        p.Codigo = reader.GetString("codigo");
                        p.Nombre = reader.GetString("nombre");
                        p.PrecioNeto = reader.GetDecimal("precio_neto");
                        p.Stock = reader.GetInt32("stock");

                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        // Operación 2: Agregar (Usa parámetros obligatorios para evitar inyección SQL)
        public void Insertar(Producto p)
        {
            string sql = @"INSERT INTO productos 
                           (codigo, nombre, precio_neto, stock, tipo, marca, meses_garantia, unidad_medida, requiere_despacho) 
                           VALUES 
                           (@codigo, @nombre, @precio, @stock, @tipo, @marca, @meses, @unidad, @despacho)";

            using (MySqlConnection cn = Conexion.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(sql, cn))
            {
                // Parámetros comunes
                cmd.Parameters.AddWithValue("@codigo", p.Codigo);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@precio", p.PrecioNeto);
                cmd.Parameters.AddWithValue("@stock", p.Stock);

                // Evaluar si es Herramienta o Material usando polimorfismo/tipos
                if (p is Herramienta h)
                {
                    cmd.Parameters.AddWithValue("@tipo", "HERRAMIENTA");
                    cmd.Parameters.AddWithValue("@marca", h.Marca);
                    cmd.Parameters.AddWithValue("@meses", h.MesesGarantia);
                    cmd.Parameters.AddWithValue("@unidad", DBNull.Value);
                    cmd.Parameters.AddWithValue("@despacho", DBNull.Value);
                }
                else if (p is Material m)
                {
                    cmd.Parameters.AddWithValue("@tipo", "MATERIAL");
                    cmd.Parameters.AddWithValue("@marca", DBNull.Value);
                    cmd.Parameters.AddWithValue("@meses", DBNull.Value);
                    cmd.Parameters.AddWithValue("@unidad", m.UnidadMedida);
                    cmd.Parameters.AddWithValue("@despacho", m.RequiereDespacho);
                }

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
