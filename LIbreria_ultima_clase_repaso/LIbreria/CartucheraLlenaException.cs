using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbreria
{
    public class CartucheraLlenaException:Exception
    {

        public CartucheraLlenaException()
            : base("La cartuchera esta llena")
        { }

    }
}
