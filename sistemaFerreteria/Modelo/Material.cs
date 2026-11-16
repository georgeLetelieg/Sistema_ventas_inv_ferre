using SistemaFerreteria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFerreteria.Modelo
{
    // Hereda de la clase base Producto
    public class Material : Producto
    {
        public string UnidadMedida { get; set; }
        public bool RequiereDespacho { get; set; }

        // Constructor
        public Material()
        {
        }

        // Sobrescritura del método polimórfico
        public override decimal CalcularPrecioFinal()
        {
            decimal precioConIva = PrecioNeto * 1.19m;

            // Si el material es voluminoso y requiere despacho, sumamos un recargo fijo de flete (ej: $5.000)
            if (RequiereDespacho)
            {
                precioConIva += 5000m;
            }

            return precioConIva;
        }
    }
}