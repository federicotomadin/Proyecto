using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Paleta
    {
       private Tempera[] _colores;
       private int _cantidadMaximaColores;



       private Paleta():this(5)       
       {
          
       }

       public Paleta(int cantidadMax)
           
       {

           _colores = new Tempera[cantidadMax];
 
           this._cantidadMaximaColores = cantidadMax;
          
       }

       public static implicit operator Paleta(int valor)
       {
           Paleta paleta=new Paleta(valor);

           return paleta;
       }



     private string Mostrar()
     {
         StringBuilder sb=new StringBuilder();
         sb.AppendLine("Cantidad Maxima "+ this._cantidadMaximaColores);

         for(int i=0;i<this._cantidadMaximaColores;i++)
         {
             if (this._colores.GetValue(i) != null)
             {
                 sb.AppendLine("Numero de la tempera  " + (i + 1));
                 sb.AppendLine("Color de la tempera  " + Tempera.Mostrar(this._colores[i]));
             }
         }

         return sb.ToString();
     }


     public static explicit operator string(Paleta paleta)
     {
        return paleta.Mostrar();
     }


     public static bool operator ==(Paleta paleta,Tempera tempera)
     {
         for (int i = 0; i < paleta._cantidadMaximaColores; i++)
         {
             if (paleta._colores.GetValue(i) != null)
             {
                 if (paleta._colores[i] == tempera)
                     return true;
             }
         }
         return false;
     }

       
     public static bool operator !=(Paleta paleta,Tempera tempera)
     {
         return !(paleta==tempera);
     }

     public static Paleta operator +(Paleta paleta, Tempera temp)
     {
         if (paleta == temp) temp += 1;



         else paleta._colores[paleta.obtenerIndice()] = temp;



         return paleta;            
       
     }


     public static Paleta operator -(Paleta paleta, Tempera temp)
     {
         int index=0;
         if (paleta == temp)
         {
             paleta._colores.GetValue(index);
             if (temp.Cantidad > 0) temp -= 1;

             else paleta._colores[index] = null;

         }

         return paleta;
        

     }


     public static Paleta operator +(Paleta paleta1, Paleta paleta2)
     {
    
         Paleta paletaNueva = new Paleta(paleta1._cantidadMaximaColores + paleta2._cantidadMaximaColores);

         for (int i = 0; i < paleta2._cantidadMaximaColores; i++)
         {
             if (paleta1._colores.GetValue(i) != null) paletaNueva += paleta1._colores[i];
         }
         
             for (int j = 0; j < paleta2._cantidadMaximaColores; j++)
             {
                 if (paleta2._colores.GetValue(j) != null)

               

                  paletaNueva += paleta2._colores[j];
             }

         

        

         return paletaNueva;


 
     }

     public int obtenerIndice()
     {
        int indice=0;

         for(int i=0;i<this._colores.Length+1;i++)
         {

             if (this._colores.GetValue(i)== null)
             {
                
                 return i;
             }
         }
         return -1;
 
     }

     public int obtenerIndice(Tempera temp)
     {
         for (int i = 0; i < this._colores.Length; i++)
         {
             if (this._colores[i] == temp) return i;
         }
        
         return -1;
     }


//+(paleta, tempera):paleta
//*->si tempera esta en paleta-->incrementa cantidad en tempera
//*->si no esta--> agrega la tempera en el primer lugar disponible


//-(paleta, tempera):paleta
//*->si tempera esta en paleta->decrementa cantidad
//*)si cantidad menor o igual a cero, elimina la tempera (null)

//+(paleta, paleta):paleta
//*->genera una paleta con los colores de ambas paletas.
//*)si temperas son iguales-->suma cantidades


////obtenerIndice + 1overload
//*)obtenerIndice():int
//*-> retorna el indice del primer lugar disponible (null) o valor neg. si no hay lugar
//*)obtenerIndice(Tempera):int
//*->retorna el indice donde se encuentra la tempera o valor neg. si no la encuentra




    }
}
