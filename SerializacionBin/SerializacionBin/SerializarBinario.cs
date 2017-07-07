using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializacionBin
{
   public class SerializarBinario
    {
       public static bool serializar(string path, Persona dato)
       {

           using (FileStream archivo = new FileStream(path,FileMode.Create))
           {

               BinaryFormatter sw = new BinaryFormatter();
               sw.Serialize(archivo, dato);



               Console.WriteLine("Serializo sin problemas");
               return true;
           }
 
           

       }
    }
}
