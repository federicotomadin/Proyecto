using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbreria
{
   public interface ISerializable
    {
       bool SerializarXml(string dato);
       bool Desderializar(string dato);
    }
}
