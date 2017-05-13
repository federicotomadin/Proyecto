using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
   public class Local:Llamada
    {
       protected  float _costo;


       public float CostoLlamada { get { return CalcularCosto(); } }


       public Local(string origen, string destino, float duracion, float costo)
           : base(origen,destino,duracion)
       {
           this._costo = costo;
       }


       public Local(Llamada unaLlamada, float costo)
           :this(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion,costo)
       {
 
       }

       private  float CalcularCosto()
       {
           return this._costo * base.Duracion;
       }

       public void Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           base.Mostrar();
           sb.AppendLine("Costo " + this.CostoLlamada);

           Console.WriteLine(sb.ToString());


       }
    }
}
