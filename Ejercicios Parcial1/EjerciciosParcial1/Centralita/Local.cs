using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Local:Llamada
    {
        protected float _costo;

        public float CostoLlamada
        {
            get
            {
                return this.Calcularcosto();
            }
        }

        private float Calcularcosto()
        {
           
            return this._costo * base._duracion;

        }

        public Local(Llamada unaLlamada, float costo)
            :this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {
          
        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            base.Mostrar();
            sb.Append("Costo llamada Local:" + this.CostoLlamada);

            Console.WriteLine(sb.ToString());
        }
            
            
           
        }
    }

