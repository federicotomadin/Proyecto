using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomadin.federico._2C
{
   public class Autor
    {
       private string _apellido;
       private string _nombre;

       public Autor(string nombre, string apellido)
       {
           this._apellido = apellido;
           this._nombre = nombre;
       }


       public static bool operator ==(Autor a, Autor b)
       {
           if (a._nombre == b._nombre && a._apellido == b._apellido)
               return true;
           else return false;
       }

       public static bool operator !=(Autor a, Autor b)
       {
           return !(a == b);
       }

       public static  implicit operator string(Autor a)
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Nombre " + a._nombre);
           sb.AppendLine("Apellido " + a._apellido);

          return  sb.ToString();
       }


    

   }
}
