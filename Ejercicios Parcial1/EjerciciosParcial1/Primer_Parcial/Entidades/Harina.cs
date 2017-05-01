using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Harina:Producto
    {

      public enum ETipoHarina
      {
          CuatroCeros,Integral
      }

      private ETipoHarina _tipo;
      public static bool DeConsumo;


      public override float CalcularCostoDeProduccion
      {

          get { return base._precio *+ (float)1.60; }
      }


      static Harina()
      {
          DeConsumo = true;
      }


      public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
           : base(codigo,marca,precio)
       {
           this._tipo = tipo;
       }


      private  string MostrarHarina()
      {
        StringBuilder sb = new StringBuilder();

       
        sb.AppendLine(this);
        sb.AppendLine("TIPO " + this._tipo);

         return sb.ToString();


      }

      public override string ToString()
      {
          return MostrarHarina();
      }




    }
}
