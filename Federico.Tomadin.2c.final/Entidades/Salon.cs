using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Punto6F;
using Entidades.Punto11;
using System.Windows.Forms;
using System.Threading;


namespace Entidades
{ 
namespace Punto11
{
    public delegate void delegadoSalon();
   

    [Serializable]
    public class Salon<T>
    {
        private List<T> _elementos;
        private int _capacidad;
        public event delegadoSalon evento;
      

        public List<T> Elementos
        {
            get { return this._elementos; }

        }

        private Salon()
        {
            this._elementos = new List<T>();
          
        }


        public Salon(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

  
        public static Salon<T> operator +(Salon<T> salon, T per)
        {

            //if (salon._elementos[0].GetType==per.GetType)


            //    throw new NoAgregaException("El elemento es del tipo " + per.GetType() + " y se esperaba  " + salon.GetType());

            if (salon._elementos.Count == salon._capacidad)
                salon.evento();

            if (salon._elementos.Count > salon._capacidad)


                throw new NoAgregaException("Capacidad al maximo");

            else salon._elementos.Add(per);

            return salon;

        }

        public  void Salon_SalonLlenoEvent()
        {
            MessageBox.Show("El salon llego a su maximo de capacidad");
        }
    }      

    }
}
