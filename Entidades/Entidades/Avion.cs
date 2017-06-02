using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion:Vehiculo,IAFIP
    {
        private double _velocidadMaxima;



        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
        }


        public double CalcularImpuesto()
        {
            return base._precio * 0.23;
        }


    }
}
