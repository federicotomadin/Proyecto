using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
     [Serializable]
      public class Local : Llamada
    {
        protected float _costo;


        public override float CostoLlamada { get { return CalcularCosto(); } }


        public Local(string origen, string destino, float duracion, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }


        public Local(Llamada unaLlamada, float costo)
            : this(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion, costo)
        {

        }




        private float CalcularCosto()
        {
            return this._costo * base.Duracion;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo " + this.CostoLlamada);

            return sb.ToString();

        }

        public override bool Equals(Object obj)
        {
            if (obj is Local) return true;
            else return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    {
    }
}
