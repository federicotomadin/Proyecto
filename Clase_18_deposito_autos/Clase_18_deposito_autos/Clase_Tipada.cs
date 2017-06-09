using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_18_deposito_autos
{
   public class Clase_Tipada<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

         public Clase_Tipada()
       {
           this._lista = new List<T>();
       }


         public Clase_Tipada(int capacidad)
             : this()
       {

           this._capacidadMaxima = capacidad;
 
       }



         public static bool operator +(Clase_Tipada<T> a, T b)
       {
           if (a.Agregar(b)) return true;
           else return false;
       }


         public static bool operator -(Clase_Tipada<T> a, T b)
       {
           if(a.Remover(b)) return true;

           else return false;

         
       }

       public int GetIndice(T a)
       {
           int count=0;
           foreach (T item in this._lista)
           {   
               count ++;
               if (item.Equals(a)) return count;
           }

           return -1;
       }


       public bool Agregar(T a)
       {
           if (this._lista.Count < this._capacidadMaxima)
           {
               this._lista.Add(a);
               return true;
           }

           return false;
       }

       public bool Remover(T a)
       {
           if (this.GetIndice(a) == -1) return false;

           else
           {
               this._lista.Remove(a);
               return true;

           }
       }

       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Listado de Autos " + this._capacidadMaxima);
           foreach (T item in this._lista)
           {
               sb.Append(item.ToString());
           }

           return sb.ToString();
       }


    }
}
