using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    namespace Punto6F
    {
        public interface IDeserializar
        {
            bool Xml(string dato, out AlumnoEgresado alumno);
        }
    }
}
