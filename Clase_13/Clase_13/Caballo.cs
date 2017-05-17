using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
   public class Caballo:Transporte
   {
       
        private string _raza;


        public override string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine((base._cantidadPasajeros).ToString());
                sb.AppendLine((base._velocidadMarcha).ToString());
                sb.AppendLine("Raza" + this._raza);

                return sb.ToString();
            }
        }


       public Caballo(int cantidadPasajeros,EVelocidad velocidadMarcha,string raza)
           :base(cantidadPasajeros,velocidadMarcha)
       {
           //this._cantidadPasajeros = cantidadPasajeros;
           //this._velocidadMarcha = velocidadMarcha;
           this._raza = raza;
       }


       public override string Frenar()
       {
           Console.WriteLine("El caballo frena hasta");
           return (Convert.ToInt32(EVelocidad.Minima)).ToString();

       }

       public override string Acelerar()
       {
           Console.WriteLine("El caballo acelera hasta");
           return (Convert.ToInt32(EVelocidad.Hiper)).ToString();

       }
    }
}
