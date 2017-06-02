using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Privado:Avion
    {
        private int _valoracionServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion)
            : base(precio, velocidad)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }
    }
}
