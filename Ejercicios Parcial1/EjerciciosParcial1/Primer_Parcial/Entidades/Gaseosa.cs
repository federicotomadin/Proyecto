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
       public static bool DeConsumo;


       static Gaseosa()
       {
           DeConsumo=true;
       }
           public Gaseosa(int codigo, EMarcaProducto marca, float precio, float litros)
           : base(codigo,marca,precio)
       {
          this._litros=litros;
       }

           public override string Consumir()
           {
               return "Bebible";
           }


           public override float CalcularCostoDeProduccion
           {

               get { return base._precio *+ (float)1.42; }
           }
       


           public Gaseosa(Producto producto, float litros):this((int)producto,producto.Marca,producto.Precio,litros)
           {
              
 
           }


           private string MostrarGaseosa()
           {
               StringBuilder sb = new StringBuilder();

               //sb.AppendLine("Litros " + this._litros);
               sb.AppendLine(base.ToString() + "Litros " + this._litros);

               return sb.ToString();
           }

           public override string ToString()
           {
               return this.MostrarGaseosa();
           }
    }
}
