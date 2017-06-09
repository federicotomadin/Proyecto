using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18_deposito_autos
{
   public class DepositoDeAutos
    {
       private int _capacidadMaxima;
       private List<Auto> _lista;


       public DepositoDeAutos()
       {
           this._lista = new List<Auto>();
       }


       public DepositoDeAutos(int capacidad):this()
       {

           this._capacidadMaxima = capacidad;
 
       }


 
       public static bool operator +(DepositoDeAutos a, Auto b)
       {
           if (a.Agregar(b)) return true;
           else return false;
       }


       public static bool operator -(DepositoDeAutos a, Auto b)
       {
           if(a.Remover(b)) return true;

           else return false;

         
       }

       public int GetIndice(Auto a)
       {
           int count=0;
           foreach (Auto item in this._lista)
           {   
               count ++;
               if (item == a) return count;
           }

           return -1;
       }


       public bool Agregar(Auto a)
       {
           if (this._lista.Count < this._capacidadMaxima)
           {
               this._lista.Add(a);
               return true;
           }

           return false;
       }

       public bool Remover(Auto a)
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
           foreach (Auto item in this._lista)
           {
               sb.Append(item.ToString());
           }

           return sb.ToString();
       }


    }
}
