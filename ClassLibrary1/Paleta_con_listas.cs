using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
  public  class Paleta_con_listas:Paleta
    {
       private List<Tempera> _colores;
       private int _cantidadMaximaColores;



       private Paleta_con_listas()      
       {
           this._colores = new List<Tempera>();
       }

       public Paleta_con_listas(int cantidadMax):this()
           
       {

           _colores = new List<Tempera>(this._cantidadMaximaColores);
 
           this._cantidadMaximaColores = cantidadMax;
          
       }

       public static implicit operator Paleta(int valor)
       {
           Paleta paleta=new Paleta(valor);

           return paleta;
       }
    }
}
