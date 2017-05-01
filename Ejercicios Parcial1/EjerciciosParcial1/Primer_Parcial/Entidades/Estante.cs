using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Entidades
{
  public   class Estante
    {

   


      protected sbyte _capacidad;
      protected  List<Producto> _productos;


        public float ValorEstanteTotal
      {
          get { return GetValorEstante(); }
      }

      private Estante()
      {
          this._productos = new List<Producto>();
      }

      public Estante(sbyte capacidad)
          : this()
      {
          this._capacidad = capacidad;
      }

      public List<Producto> GetProductos()
      {
          return this._productos;
      }


      private float GetValorEstante()
      {
          float acumulador = 0;

          foreach (Producto item in _productos)
          {
              acumulador += item.Precio;
 
          }

          return acumulador;
      }

      public float GetValorEstante(Producto.ETipoProducto tipo)
      {
          float galletita = 0;
          float jugo = 0;
          float gaseosa = 0;
          float resultado=0;

          foreach (Producto item in _productos)
          {
              if (item is Galletita)
                  galletita += item.Precio;
              if (item is Jugo)
                  jugo += item.Precio;
              if (item is Gaseosa)
                  gaseosa += item.Precio;

          }

          if (tipo == Producto.ETipoProducto.Galletita) resultado= galletita;
          if (tipo == Producto.ETipoProducto.Gaseosa) resultado = gaseosa;
          if (tipo == Producto.ETipoProducto.Jugo) resultado = jugo;
          if (tipo == Producto.ETipoProducto.Todos) return this.GetValorEstante();

          return resultado;
      }

          

      public static string MostrarEstante(Estante est)
      {
          StringBuilder sb = new StringBuilder();

          sb.AppendLine("Capacidad  " + est._capacidad);

          foreach (Producto item in est._productos)
          {
              if (item is Harina) sb.AppendLine(((Harina)item).ToString());
              if (item is Gaseosa) sb.AppendLine(((Gaseosa)item).ToString());
                if (item is Galletita) sb.AppendLine(((Galletita)item).ToString());
               if (item is Jugo) sb.AppendLine(((Jugo)item).MostrarJugo());
          }

          
          return sb.ToString();
      }

      public static bool operator ==(Estante est, Producto prod)
      {
          foreach (Producto item in est._productos)          
          {
              if (item == prod) return true;
              break;
          }

          return false;
      }

      public static bool operator !=(Estante est, Producto prod)
      {
          return !(est == prod);
      }

      public static bool operator +(Estante est, Producto prod)
      {
          if (est != prod)
          {
              if (est._productos.Count < est._capacidad)
              {
                  est._productos.Add(prod);
                  return true;

              }
          }

           return false;
      }


      public static Estante operator -(Estante est, Producto prod)
      {

          if (est == prod) est._productos.Remove(prod);

          return est;
          
      }


      public static Estante operator -(Estante est, Producto.ETipoProducto tipo)
      {
          foreach (Producto item in est._productos)
          {
              if ((Producto.ETipoProducto)item.Marca == tipo) est -= item;
          }

          return est;
      }




     
    }
}
