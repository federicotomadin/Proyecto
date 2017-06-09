using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18_deposito_autos
{
   public class DepositoDeCocinas
    {
         private int _capacidadMaxima;
       private List<Cocina> _lista;


       public DepositoDeCocinas()
       {
           this._lista = new List<Cocina>();
       }


       public DepositoDeCocinas(int capacidad):this()
       {

           this._capacidadMaxima = capacidad;
 
       }


 
       public static bool operator +(DepositoDeCocinas a, Cocina b)
       {
           if (a.Agregar(b)) return true;
           else return false;
       }


       public static bool operator -(DepositoDeCocinas a, Cocina b)
       {
           if(a.Remover(b)) return true;

           else return false;

         
       }

       public int GetIndice(Cocina a)
       {
           int count=0;
           foreach (Cocina item in this._lista)
           {   
               count ++;
               if (item == a) return count;
           }

           return -1;
       }


       public bool Agregar(Cocina a)
       {
           if (this._lista.Count < this._capacidadMaxima)
           {
               this._lista.Add(a);
               return true;
           }

           return false;
       }

       public bool Remover(Cocina a)
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

           sb.AppendLine("Capacidad Maxima " + this._capacidadMaxima);
           foreach (Cocina item in this._lista)
           {
               sb.Append(item.ToString());
           }

           return sb.ToString();
       }
    }
}
