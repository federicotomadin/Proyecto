﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Deportivo:Auto,IAFIP,IARBA
    {
       private int _cabalosFuerza;

       public Deportivo(double precio, string patente, int hp)
           : base(precio,patente)
       {

           this._cabalosFuerza = hp;
 
       }


       double IAFIP.CalcularImpuesto()
       {
           return base._precio * 0.28;
       }

       double IARBA.CalcularImpuesto()
       {
           return base._precio *0.23;
       }
    }
}
