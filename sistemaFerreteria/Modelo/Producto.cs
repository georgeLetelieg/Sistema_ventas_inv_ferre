using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFerreteria.Modelo
{
    // El modificador 'public' aquí es clave para que Herramienta y Material puedan heredar
    public abstract class Producto
    {
        private decimal _precioNeto;
        private int _stock;

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public decimal PrecioNeto
        {
            get { return _precioNeto; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio neto no puede ser negativo.");
                _precioNeto = value;
            }
        }

        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El stock no puede ser negativo.");
                _stock = value;
            }
        }

        // El modificador 'public' aquí es clave para solucionar el error CS0115
        public abstract decimal CalcularPrecioFinal();
    }
}