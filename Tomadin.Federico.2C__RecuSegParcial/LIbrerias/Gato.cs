using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbrerias
{
   public class Gato:Mascota
    {

       public Gato(string nombre, string raza)
           : base(nombre, raza)
       { }



       public static bool operator ==(Gato g1, Gato g2)
       {
           if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza) return true;

           else return false;
       }



       public static bool operator !=(Gato g1, Gato g2)
       {
           return !(g1 == g2);
       }



        public override bool Equals(object obj)
        {
          return  base.Equals(obj);
        }

        protected override string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Nombre + " " +  base.Raza);
           

            return sb.ToString();
        }

        protected override string Ficha()
        {
            return DatosCompletos();

        }

        public override string ToString()
        {
            return this.Ficha();
        }


       
    }
}
