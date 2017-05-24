using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Consola
{
    public static class MetdosExtension
    {






        public static void ObtenerInfo(this PersonaExternaSellada P )
        {
            Console.WriteLine(P.Nombre);
            Console.WriteLine(P.Apellido);
            Console.WriteLine(P.Edad);
            Console.WriteLine(P.Sexo);
        }

    
    }
}
