using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercial:Avion
    {
        private int _capacidadPasajeros;


        public Comercial(double precio, double velocidad, int pasajeros):base(precio,velocidad)
        {

            this._capacidadPasajeros = pasajeros;
 
        }


        public double CalcularImpuesto()
        {
            return this._precio * 1.25;
        }
    }
}
