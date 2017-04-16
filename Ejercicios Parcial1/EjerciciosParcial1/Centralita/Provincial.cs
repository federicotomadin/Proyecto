using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;


        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        
        
        private float CalcularCosto()
        {
            
                float costo;

                switch (this._franjaHoraria)
                {
                    case Franja.Franja_1:
                        costo = base._duracion * (float)0.99;
                        break;

                    case Franja.Franja_2:
                        costo = base._duracion * (float)1.25;
                        break;

                    case Franja.Franja_3:
                        costo = base._duracion * (float)0.66;
                        break;

                    default:
                        costo = 0;
                        break;
                }

                return costo;
            
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            :this(unaLlamada.NroOrigen,miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            base.Mostrar();
            sb.Append("Franja:" + this._franjaHoraria + "\n");
            sb.Append("Costo llamada Provincia:" + this.CostoLlamada);
            

            Console.WriteLine(sb.ToString());
        }

                        





    }
}
