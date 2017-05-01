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
        public static bool DeConsumo;


        static Galletita()
        {
            DeConsumo = true;
        }

        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso)
           : base(codigo,marca,precio)
       {
           this._peso=peso;
       }

          public override string Consumir()
          {
              return "Comestible";
          }

          public override float CalcularCostoDeProduccion
          {

              get { return base._precio *+ (float)1.33; }
          }
       


          private static string MostrarGalletita(Galletita galletita)
          {
              StringBuilder sb = new StringBuilder();            
              sb.AppendLine(galletita);
              sb.AppendLine("Peso de la galleta   " + galletita._peso);

              return sb.ToString();


          }

          public override string ToString()
          {
              return Galletita.MostrarGalletita(this);
          }
    }
}
