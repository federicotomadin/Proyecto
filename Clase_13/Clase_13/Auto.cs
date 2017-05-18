using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
   public class Auto:Trasporte_Terrestre
    {
       
       private int _cantRuedas;


       public override string Detalle
       {
           get
           {
               StringBuilder sb = new StringBuilder();

               sb.AppendLine((base._cantidadPasajeros).ToString());
               sb.AppendLine((base._velocidadMarcha).ToString());
               sb.AppendLine("Cantidad de ruedas " + this._cantRuedas);

               return sb.ToString();
           }
       }

       public Auto(int cantidadPasajeros, EVelocidad velocidadMarcha, int cantRuedas)
           :base(cantidadPasajeros,velocidadMarcha)
       {
           //this._cantidadPasajeros = cantidadPasajeros;
           //this._velocidadMarcha = velocidadMarcha;
           this._cantRuedas = cantRuedas;
       }


       public override string Frenar()
       {
         
           return "El auto frena hasta" + (Convert.ToInt32(EVelocidad.Minima)).ToString();

       }

       public override string Frenar(string condicion)
       {
           if (condicion == "frenar") return "frenar";
           else return "no frena";
       }


       public override string Acelerar()
       {
           
           return "El auto acelera hasta" + (Convert.ToInt32(EVelocidad.Hiper)).ToString();
 
       }

    }
}
