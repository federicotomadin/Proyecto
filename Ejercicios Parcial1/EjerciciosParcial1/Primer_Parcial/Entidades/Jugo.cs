using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Jugo:Producto
    {
       public enum ESaborJugo
       {
           Asqueroso,Pasable,Rico
       }

       private ESaborJugo _sabor;
       public static bool DeConsumo;

       static Jugo()
       {
           DeConsumo = true;
       }

       public Jugo(int codigo, EMarcaProducto marca, float precio, ESaborJugo sabor)
           : base(codigo,marca,precio)
       {
           this._sabor = sabor;
       }


       public override float CalcularCostoDeProduccion
       {
       
          get { return base._precio*(float)0.40; }
       }
       


       public string MostrarJugo()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Sabor " + this._sabor);
           sb.AppendLine(base.ToString());

           return sb.ToString();

           
       }
    }
}
