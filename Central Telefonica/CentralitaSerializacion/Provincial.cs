using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    [Serializable]
    public  class Provincial:Llamada
    {
      
       protected Franja _franjaHoraria;


       public override float CostoLlamada { get { return CalcularCosto(); } }


          public Provincial(string origen, string destino, float duracion, Franja franja)
           : base(origen,destino,duracion)
       {
           this._franjaHoraria = franja;
       }


       public Provincial(Llamada unaLlamada, Franja franja)
           :this(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion,franja)
       {
 
       }

       private  float CalcularCosto()
       {
           if (this._franjaHoraria == Franja.Franja_1) return 0.99f;
           if (this._franjaHoraria == Franja.Franja_2) return 1.25f;

           if (this._franjaHoraria == Franja.Franja_3) return 0.66f;

           else return 0;

       }

       protected string Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine(base.Mostrar());
           sb.AppendLine("Franja " + this._franjaHoraria);
           sb.AppendLine("Costo " + this.CostoLlamada);

           return sb.ToString();

       }

        public override bool Equals(Object obj)
        {
            if (obj is Provincial) return true;
            else return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    
    }
}
