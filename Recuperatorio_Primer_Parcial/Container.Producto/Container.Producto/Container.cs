using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container.Producto
{
   public class Container
    {
       public enum ETipoComestible
       {
           Solido,Liquido
       }
    
 

       private int _capacidad;
       private string _empresa;
       private List<Producto> _lista;



       public Container(int capacidad, string empresa)
       {
           this._capacidad = capacidad;
           this._empresa = empresa;
           this._lista = new List<Producto>();
       }

       public static void Mostrar(Container contenedor)
       {
           

           Console.WriteLine("Capacidad: " + contenedor._capacidad);
           Console.WriteLine("Empresa " + contenedor._empresa);

           foreach (Producto item in contenedor._lista)
           {
               item.Mostrar();
 
           }
        
          
       }

       public bool Agregar(Producto proUno)
       {
           if (this._lista.Count < this._capacidad)
           {
               this._lista.Add(proUno);
               return true;
           }
           return false;
 
       }

       public static List<Producto> operator -(Container ContenedorUno, ETipoComestible tipo)
       {
           List<Producto> aux=new List<Producto>();

           foreach (Producto item in ContenedorUno._lista)
           {
               if (item==tipo) aux.Add(item);
 
           }

          return aux;
       }


       public static bool operator ==(Container contenedor,Producto proUno)
       {
            foreach (Producto item in contenedor._lista)
           {
               if (item==proUno) return false;
 
           }

           contenedor._lista.Add(proUno);
           return true;
           
       }


       public static bool operator !=(Container contenedor, Producto proUno)
       {
           return !(contenedor == proUno);
       }
     



       


    }
}
