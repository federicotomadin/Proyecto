using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbrerias
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;


        public string Nombre
        {
            get { return this._nombre; }
        }

        public string Raza
        {
            get { return this._raza; }
        }

        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        //public static bool operator ==(Mascota m1, Mascota m2)
        //{
        //    if (m1.Nombre == m2.Nombre && m1.Raza == m2.Raza) return true;
        //    else return false;
        //}

        //public static bool operator !=(Mascota m1, Mascota m2)
        //{
        //    return !(m1 == m2);
        //}


        protected virtual string DatosCompletos()
        {
            string cadena = (this.Nombre + " " +  this.Raza);

            return cadena;

        }


        protected abstract string Ficha();
    
    }
}
