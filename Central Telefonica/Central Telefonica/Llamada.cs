using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
   public class Llamada
    {
       protected float _duracion;
       protected string _nroDestino;
       protected string _nroOrigen;


       public float Duracion
       {
           get { return _duracion; }
       }

       public string NroOrigen { get { return _nroOrigen; } }

       public string NroDestino { get { return _nroDestino; } }



       public Llamada(string origen, string destino, float duracion)
       {
           this._nroOrigen = origen;
           this._nroDestino = destino;
           this._duracion = duracion;
       }


       public void Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Numero de origen " + this._nroOrigen);
           sb.AppendLine("Numero de destino " + this._nroDestino);
           sb.Append("Duracion " + this._duracion);

           Console.WriteLine(sb.ToString());

       }


       public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
       {
           
           if (uno.Duracion > dos.Duracion) return 1;

            if (uno.Duracion < dos.Duracion) return -1;

           else return 0;

          
       }
    }
}
