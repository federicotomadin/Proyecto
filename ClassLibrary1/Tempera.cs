using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Tempera
    {
       private ConsoleColor _color;
       private string _marca;
       private int _cantidad;



       public Tempera(ConsoleColor color,string marca,int cantidad)
       {
           this._color=color;
           this._marca=marca;
           this._cantidad=cantidad;
       }

       public int Cantidad
       {
           get { return this._cantidad; }
       }
 

       /// <summary>
       /// Metodo privado de intantcia
       /// </summary>
       /// <returns></returns>
       private string Mostrar()
       {
           StringBuilder sb=new StringBuilder();

           sb.AppendLine("Color " + this._color);
           sb.AppendLine("Marca " + this._marca);
           sb.AppendLine("Cantidad " + this._cantidad);

           return sb.ToString();
       }


       /// <summary>
       /// Metodo sobrecargado publico que llama al privado
       /// </summary>
       /// <param name="temp"></param>
       /// <returns></returns>
       public static string Mostrar(Tempera temp)
       {
           return temp.Mostrar();
       }


       

      /// <summary>
      /// metodo que compara dos variables
      /// </summary>
      /// <param name="temp1"></param>
      /// <param name="temp2"></param>
      /// <returns></returns>
      public static bool operator ==(Tempera temp1, Tempera temp2)
      {
          if(temp1._marca==temp2._marca && temp1._color==temp2._color)
              return true;

          else return false;
      }


       
     public static bool operator !=(Tempera temp1, Tempera temp2)
      {
         return !(temp1==temp2);

       }

    public static implicit operator int(Tempera temp)
    {
        return temp._cantidad;
    }


    public static explicit operator string(Tempera temp)
    {
        return temp.Mostrar();
    }


    public static Tempera operator +(Tempera temp1, Tempera temp2)
    {
        if (temp1 == temp2) temp1._cantidad++;
        

        return temp1;
    }

   public static Tempera operator +(Tempera temp, int entero)
   {
       temp._cantidad+=entero;

       return temp;
   }



   public static Tempera operator -(Tempera temp, int entero)
   {
       temp._cantidad -= entero;

       return temp;
   }


    }
}
