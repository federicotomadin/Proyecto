using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
    public abstract class Transporte
    {
        protected int _cantidadPasajeros;
        protected EVelocidad _velocidadMarcha;
        private List<Transporte> _lista;


        public Transporte()
        {
            _lista = new List<Transporte>();
        }

        public abstract string Detalle { get; }
        //{

        //    get
        //    {
        //        StringBuilder sb = new StringBuilder();

        //        sb.AppendLine("Cantidad de pasajeros" + this._cantidadPasajeros);
        //        sb.AppendLine("Velocidad de la marcha" + this._velocidadMarcha);

        //        return sb.ToString();
        //    }
        //}


        public  Transporte(int cantidadPasajeros, EVelocidad velocidadMarcha)
        {
            this._cantidadPasajeros = cantidadPasajeros;
            this._velocidadMarcha = velocidadMarcha;
        }


        public abstract string Frenar();
        
            //Console.WriteLine("El vehiculo frena hasta");
            //return (Convert.ToInt32(EVelocidad.Minima)).ToString();



        public virtual string Acelerar()
        {

            Console.WriteLine("El vehiculo acelera hasta");
            return (Convert.ToInt32(EVelocidad.Hiper)).ToString();
        }
        
    }
}
