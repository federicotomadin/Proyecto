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


       public Jugo(int codigo, EMarcaProducto marca, float precio, ESaborJugo sabor)
           : base(codigo,marca,precio)
       {
           this._sabor = sabor;
       }


       public string MostrarJugo()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Sabor " + this._sabor);
           sb.AppendLine(base.MostrarProducto(this));

           return sb.ToString();

           
       }
    }
}
