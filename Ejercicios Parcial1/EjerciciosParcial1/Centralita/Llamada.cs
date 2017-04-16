using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
  class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        public Llamada() { }

        public virtual void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nro Origen:" + this._nroOrigen + "\n");
            sb.Append("Nro Destino:" + this._nroDestino + "\n");
            sb.Append("Duracion:" + this._duracion + "\n");

            Console.WriteLine(sb.ToString());
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int valor = 0;

            if (uno._duracion.CompareTo(dos._duracion) > 0)
            {
                valor = 1;
            }


            if (uno._duracion.CompareTo(dos._duracion) < 0)
            {
                valor = -1;
            }

            return valor;
        }



    }
}
