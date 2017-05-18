using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
    public abstract class Trasporte_Terrestre:Transporte
    {



        public Trasporte_Terrestre(int cantidadPasajeros, EVelocidad velocidadMarcha)
            : base(cantidadPasajeros, velocidadMarcha)
        { }



    }
}
