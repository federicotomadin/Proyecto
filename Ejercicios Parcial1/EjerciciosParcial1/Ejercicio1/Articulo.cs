using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Articulo
    {
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int stock;

        public string NombreYCodigo
        {
            get
            {
                return this._nombre +"-"+this._codigo;
            }
        }

        public float PrecioCosto
        {
            set
            {
                this._precioCosto = value;
                this._precioVenta = this._precioCosto*(float)1.3;
            }
        }

        public float PrecioVenta
        {
            get
            {
                return this._precioVenta;
                
            }
        }

        public int Stock
        {
            set
            {
                this.stock =value;
            }
        }

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this.PrecioCosto = precioCosto;
            this.stock = cantidad;
        }

        public bool HayStock(int cantidad)
        {
            if (this.stock >= cantidad)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Articulo uno, Articulo dos)
        {
            if (uno._nombre == dos._nombre && uno._codigo == dos._codigo)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Articulo uno, Articulo dos)
        {
            return !(uno == dos);
        }

        public static int operator +(Articulo uno, Articulo dos)
        {
            int resultado = uno.stock + dos.stock;

            return resultado;
        }

        public static int operator -(Articulo uno, int cantidad)
        {
            int resultado = uno.stock - cantidad;

            return resultado;
        }



            
    }
}
