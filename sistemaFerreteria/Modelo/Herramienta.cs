using SistemaFerreteria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFerreteria.Modelo
{
    // Hereda de la clase base Producto
    public class Herramienta : Producto
    {
        private int _mesesGarantia;

        public string Marca { get; set; }

        // Propiedad con validación en el setter para cumplir con la rúbrica
        public int MesesGarantia
        {
            get { return _mesesGarantia; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Los meses de garantía no pueden ser negativos.");
                _mesesGarantia = value;
            }
        }

        // Constructor
        public Herramienta()
        {
        }

        // Sobrescritura del método polimórfico
        public override decimal CalcularPrecioFinal()
        {
            // La herramienta solo aplica el 19% de IVA estándar
            return PrecioNeto * 1.19m;
        }
    }
}
