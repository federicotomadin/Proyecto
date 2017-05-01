using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract  class Producto
    {

       public enum ETipoProducto
       {
           Galletita, Gaseosa, Jugo, Harina,Todos
       }

       public enum EMarcaProducto
       {
           Manaos,Pitusas,Naranjú,Diversión,Swift,Favorita
       }

       #region Atributos
       protected int _codigoBarra;
       protected EMarcaProducto _marca;
       protected float _precio;

       #endregion

       #region Constructor
       public Producto(int codigo, EMarcaProducto marca, float precio)
       {
           this._codigoBarra = codigo;
           this._marca = marca;
           this._precio = precio;
       
       }
       #endregion


       #region Propiedades
       public EMarcaProducto Marca
       {
           get { return this._marca; }


       }

       public abstract float CalcularCostoDeProduccion { get; }

       public float Precio
       {
           get { return this._precio; }
       }
       #endregion 

        #region Metodos


       public static explicit operator int(Producto prod)
       {
           return prod._codigoBarra;
       }


      private static  string MostrarProducto(Producto prod)
       {
           StringBuilder sb = new StringBuilder();


           sb.AppendLine("Marca " + prod.Marca);
           sb.AppendLine("Codigo de barra " + prod._codigoBarra);
           sb.AppendLine("Precio " + prod.Precio);


           return sb.ToString();
       }

      public virtual string Consumir()
      {
          return "Parte de una mezcla";
      }


       
       public override bool Equals(object obj)
       {
           return obj is Producto;
       }



       public static implicit operator string(Producto p)
       {
           return  Producto.MostrarProducto(p);
       }




       public static bool operator ==(Producto prodUno, Producto prodDos)
       {
           if (prodUno.Marca == prodDos.Marca && prodUno._codigoBarra == prodDos._codigoBarra)
               return true;
           else return false;
       }

       public static bool operator ==(Producto prodUno, EMarcaProducto marca)
       {
           if (prodUno.Marca == marca) return true;
           else return false;
       }



    
       public static bool operator !=(Producto prodUno, EMarcaProducto marca)
       {
           return !(prodUno == marca);

       }



       public static bool operator !=(Producto prodUno, Producto prodDos)
       {
           return !(prodUno == prodDos);
       }



        #endregion





    }
}
