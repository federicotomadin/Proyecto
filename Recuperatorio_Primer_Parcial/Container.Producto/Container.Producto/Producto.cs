using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Container;

namespace Container.Producto
{
    public class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private Container.ETipoComestible _tipo;



        public Producto(int codigoDeBarra)

        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoDeBarra, string nombre, Container.ETipoComestible tipo):this(codigoDeBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }


        public Producto(int codigoDeBarra, string nombre, Container.ETipoComestible tipo, double precio)
            : this(codigoDeBarra,nombre,tipo)
        {
            this._precio = precio;
 
        }


        public void Mostrar()
        {
           
            Console.WriteLine("Codigo de barra: " + this._codigoDeBarra);
            Console.WriteLine("Nombre " + this._nombre);
            Console.WriteLine("Precio " + this._precio);
            Console.WriteLine("Tipo " + this._tipo);

          

        
        }


        public static bool operator ==(Producto proUno, Container.ETipoComestible tipo)
        {
            if (proUno._tipo == tipo) return true;
            else return false;
 
        }

        public static bool operator !=(Producto proUno, Container.ETipoComestible tipo)
        {
            return !(proUno == tipo);
        }


        public static bool operator ==(Producto proUno, Producto proDos)
        {
            if (proUno._codigoDeBarra == proDos._codigoDeBarra) return true;

            else return false;
        }


        public static bool operator !=(Producto proUno, Producto proDos)
        {
            return !(proUno == proDos);
        }



    }
}
