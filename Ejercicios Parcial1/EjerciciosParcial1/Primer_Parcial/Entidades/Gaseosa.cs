using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Gaseosa:Producto
    {

       private float _litros;

           public Gaseosa(int codigo, EMarcaProducto marca, float precio, float litros)
           : base(codigo,marca,precio)
       {
          this._litros=litros;
       }


           public Gaseosa(Producto producto, float litros):this((int)producto,producto.Marca,producto.Precio,litros)
           {
              
 
           }


           public string MostrarGaseosa()
           {
               StringBuilder sb = new StringBuilder();

               sb.AppendLine("Litros " + this._litros);
               sb.AppendLine(base.MostrarProducto(this));

               return sb.ToString();
           }
    }
}
