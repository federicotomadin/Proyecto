using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
   public  class Provincial:Llamada
    {

      

       protected Franja _franjaHoraria;


       public float CostoLlamada { get { return CalcularCosto(); } }


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

       public void Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           base.Mostrar();
           sb.AppendLine("Costo " + this.CostoLlamada);

           Console.WriteLine(sb.ToString());


       }
    }
}
