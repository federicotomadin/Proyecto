using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
   public class ClaseFabrica
    {

       private static string _atributo;


       static ClaseFabrica()
       {
           ClaseFabrica._atributo = "ejemplo";
       }

       public ClaseFabrica(string atributo)
       {
           ClaseFabrica._atributo = atributo;
       }

       public string  Atributo
       {
           get {
                  ClaseFabrica clase = new ClaseFabrica("ejemplo2");
                  return Atributo;
 
               }
       }
   


    }
}
