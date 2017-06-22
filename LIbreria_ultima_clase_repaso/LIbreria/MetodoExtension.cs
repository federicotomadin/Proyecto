using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbreria
{
   public static class MetodoExtension
    {
       

       public static bool Extencion(this ISerializable obj,string dato)
       {
           return (obj.SerializarXml(dato));
       }
    }
}
