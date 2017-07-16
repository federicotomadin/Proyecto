using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    namespace Punto11
    {
      public  class NoAgregaException : Exception
        {



            public NoAgregaException(string message)
                : base(message)
            { }

         
        }
    }
}
