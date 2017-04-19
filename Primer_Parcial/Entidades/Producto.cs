using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Producto
    {
       public enum EMarcaProducto
       {
           Manaos,Pitusas,Naranju,Diversion,Swift
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


       protected string MostrarProducto(Producto prod)
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Codigo de barra " + this._codigoBarra);
           sb.AppendLine("Marca " + this.Marca);
           sb.AppendLine("Precio " + this.Precio);


           return sb.ToString();
       }

       public static bool operator ==(Producto prodUno, EMarcaProducto marca)
       {
           if (prodUno.Marca == marca)
               return true;

           else return false;
       }

       public static bool operator !=(Producto prodUno, EMarcaProducto marca)
       {
           return !(prodUno == marca);
       }


       public static bool operator ==(Producto prodUno, Producto prodDos)
       {
           if (prodUno.Marca == prodDos.Marca && prodUno._codigoBarra == prodDos._codigoBarra)
               return true;
           else return false;
               
       }

       public static bool operator !=(Producto prodUno, Producto prodDos)
       {
           return !(prodUno == prodDos);
       }



        #endregion





    }
}
