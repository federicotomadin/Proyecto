using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        private float _peso;

          public Galletita(int codigo, EMarcaProducto marca, float precio, float peso)
           : base(codigo,marca,precio)
       {
           this._peso=peso;
       }


          public string MostrarGalletita(Galletita galletita)
          {
              StringBuilder sb = new StringBuilder();

              sb.AppendLine("Peso de la galleta" + galletita._peso);
              sb.AppendLine(base.MostrarProducto(galletita));

              return sb.ToString();


          }
    }
}
