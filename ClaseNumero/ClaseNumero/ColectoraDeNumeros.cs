using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNumero
{
   public class ColectoraDeNumeros
    {
       public enum ETipoNumero
       { Par,Impar,Positivo,Negativo,Cero}


       protected List<Numero> _numeros;


       public ETipoNumero TipoNumero
       {
           get;
           set;
       }

       private ColectoraDeNumeros()
       {
           _numeros =new List<Numero>();
       }

       public ColectoraDeNumeros(ETipoNumero numero):this()
       {
           this.TipoNumero = numero;
       }

       public static bool operator ==(ColectoraDeNumeros col, Numero num)
       {
           foreach (Numero item in col._numeros)
           {
               if (item.NumeroProp == num.NumeroProp) return true;
           }
           return false;
       }

       public static bool operator !=(ColectoraDeNumeros col, Numero num)
       {
           return !(col == num);
       }


       public static ColectoraDeNumeros operator +(ColectoraDeNumeros col, Numero num)
       {



           switch (col.TipoNumero)
           {
               case ETipoNumero.Par:
                   if (num.NumeroProp % 2 == 0)
                       col._numeros.Add(num);
                   else Console.WriteLine("El numero no era par");
                   break;
               case ETipoNumero.Impar:
                   if (num.NumeroProp % 2 != 0)
                       col._numeros.Add(num);
                   else Console.WriteLine("El numero no era impar");
                   break;
               case ETipoNumero.Positivo:
                   if (num.NumeroProp > 0)
                       col._numeros.Add(num);
                   else Console.WriteLine("El numero no es positivo");
                   break;
               case ETipoNumero.Negativo:
                   if (num.NumeroProp < 0)
                       col._numeros.Add(num);
                   else Console.WriteLine("El numero no es negativo");
                   break;
               case ETipoNumero.Cero:
                   if (num.NumeroProp == 0)
                       col._numeros.Add(num);
                   else Console.WriteLine("El numero no es cero");
                   break;
               default:
                   break;
           }

           return col;
       }


       public static ColectoraDeNumeros operator -(ColectoraDeNumeros col, Numero num)
       {
           if (col == num) col._numeros.Remove(num);

           return col;
       }


       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();


           sb.AppendLine("Mi clase almacena " + this.TipoNumero);

           foreach (Numero item in _numeros)
           {
               sb.AppendLine("El numero es " + item.NumeroProp);
 
           }

           return sb.ToString();
       }










//       2-Clase ColectoraDeNumeros
//* protected list<Numero> _numeros
//* prop. autodefinida TipoNumero --> * ETipoNumero{Par, Impar, Positivo, Negativo, Cero}
//* constr. por default (privado)
//* constr. un parametro ETipoNumero.

//* sobrecarga == (ColectoraDeNumeros, Numero) : bool
//-->si el Numero esta en la coleccion, true. Caso contrario, false.
//* sobrecarga + (ColectoraDeNumeros, Numero) : ColectoraDeNumeros
//-->si el Numero coincide con el ETipoNumero), agregarlo. Caso contrario Mostrar mensaje
//* sobrecarga - (ColectoraDeNumeros, Numero) : ColectoraDeNumeros
//-->si el Numero esta en la coleccion, quitarlo (la primera ocurrencia). Caso contrario mostrar mensaje.

//*polimorfismo ToString

    }
}
