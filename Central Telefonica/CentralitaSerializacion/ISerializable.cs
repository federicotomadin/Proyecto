using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
   public interface ISerializable
    {
       string RutaDelArchivo { get; set; }

        bool DeSerializarse();

        bool Serializarse();
    }
}
