using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomadin.federico._2C
{
   public  class Manual:Libro
    {
      

       public ETipo tipo;


       public Manual(string titulo, float precio, string nombre, string apellido,ETipo tipo)
           : base(precio,titulo, nombre, apellido)
       {
           this.tipo = tipo;
 
       }


       public string Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine((string)this);
           sb.AppendLine("Tipo " + this.tipo);

           return sb.ToString();

       }

       public static bool operator ==(Manual a, Manual b)
       {
           if (a.tipo == b.tipo && a == b)
               return true;
           else return false;
 
       }


       public static bool operator !=(Manual a, Manual b)
       {
           return !(a == b);
       }





    }
}
