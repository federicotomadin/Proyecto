using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
   public class Cohete:Transporte
    {
       private string _modelo;
       private int _cantidadVentanas;


       public Cohete(int cantidadPasajeros, EVelocidad velocidadMarcha, string modelo, int cantVentanas)
           :base(cantidadPasajeros,velocidadMarcha)
       {
           //this._cantidadPasajeros = cantidadPasajeros;
           //this._velocidadMaxima = velocidadMaxima;
           this._modelo = modelo;
           this._cantidadVentanas = cantVentanas;
       }

       public override string Detalle
       {
           get
           {
               StringBuilder sb = new StringBuilder();

               sb.AppendLine((base._cantidadPasajeros).ToString());
               sb.AppendLine((base._velocidadMarcha).ToString());
               sb.AppendLine("Modelo " + this._modelo);
               sb.AppendLine("Cantidad de Ventanas " + this._cantidadVentanas);

               return sb.ToString();
           }
       }


       public override string Frenar()
       {

           return "El cohete frena hasta" + (Convert.ToInt32(EVelocidad.Minima)).ToString();

       }

       public override string Frenar(string condicion)
       {
           if (condicion == "frenar") return "frenar";
           else return "no frena";
       }

       public override string Acelerar()
       {

           return "El cohete acelera hasta" + (Convert.ToInt32(EVelocidad.Hiper)).ToString();
 
       }
    }
}
