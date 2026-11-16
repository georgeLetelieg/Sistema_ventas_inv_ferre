using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SistemaFerreteria.Utilidades
{
    public static class Seguridad
    {
        // Método de referencia extraído del Anexo D de la guía, adaptado para .NET Framework
        public static string CalcularHash(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                // En .NET Framework usamos BitConverter en lugar de Convert.ToHexString
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}