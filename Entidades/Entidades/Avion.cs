﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected  double _velocidadMaxima;



        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }


        double IAFIP.CalcularImpuesto()
        {
            return base._precio * 1.23;
        }


        double IARBA.CalcularImpuesto()
        {
            return base._precio * 1.27;
        }
    }
}
