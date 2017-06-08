using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase_17_Humano
{
    public class Persona:Humano
    {
       private string apellido;
       private string nombre;

 

       public Persona()
       {
          
       }

       public Persona(int dni,string nombre, string apellido):this()
       {
           this.nombre = nombre;
           this.apellido = apellido;
           this.Guardar();
 
       }

       public void Guardar()
       {

           try
           {
              using (StreamWriter txt = new StreamWriter(@"D:\Persona.txt", false))
             {

               txt.WriteLine(this.nombre);
               txt.WriteLine(this.apellido);
               txt.WriteLine(DateTime.Now);
             }
           }
           catch (Exception e)
           {
               throw e;
           }
       }

       public void Leer(out string texto)
       {
         
           try
           {
               StreamReader reader = new StreamReader(@"D:\Pna.txt", true);
               
               
                   texto = reader.ReadToEnd();
                   

              
           }
           catch (Exception)
           {
               
               throw;
           }

           
       }


       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine(this.nombre);
           sb.AppendLine(this.apellido);
           

           return sb.ToString();
       }
    }
}
