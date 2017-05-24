using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
   public static class ClaseExtendidaString
    {


       public static int Cantidad(this string s)
       {
           return s.Length;
       }

    }
}
