using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;

namespace Ejercicio1Clase2
{
    class Venta
    {
        private Articulo _articuloVendido;
        private int _cantidad;

        public float RetornarGanancia()
        {
            float ganancia = this._articuloVendido.PrecioVenta * this._cantidad;

            return ganancia;
        }

        public Venta(Articulo articuloVendido, int cantidad)
        {
            this._articuloVendido = articuloVendido;
            this._cantidad = cantidad;
        }
    }
}
