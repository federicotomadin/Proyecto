using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDatos
{
   public  class Persona
    {
       public int id;
       public string apellido;
       public string nombre;
       public int edad;


       public Persona()
       { }


       public override string ToString()
       {
          StringBuilder sb=new StringBuilder();

           sb.AppendLine("Id " + this.id);
           sb.AppendLine("Apellido " + this.apellido);
           sb.AppendLine("Nombre " + this.nombre);
           sb.AppendLine("Edad " + this.edad);

 	      return sb.ToString();

       }


 
       
    }
}
