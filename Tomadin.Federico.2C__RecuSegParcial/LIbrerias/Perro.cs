using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbrerias
{
   public class Perro:Mascota
    {

       private int _edad;
       private bool _esAlfa;





       public Perro(string nombre, string raza)
           : base(nombre, raza)
       {
           this._edad = 0;
           this._esAlfa = false;
       }


       public Perro(string nombre , string raza,int edad,bool esAlfa)
           : base(nombre, raza)
       {
           this._edad = edad;
           this._esAlfa = esAlfa;
       }



       public override bool Equals(object obj)
       {
           if (obj is Perro) return true;
           else return false;
       }


       public static bool operator ==(Perro p1, Perro p2)
       {
           if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad) return true;

           else return false;
       }


       public static bool operator !=(Perro p1, Perro p2)
       {
           return !(p1 == p2);
       }


       public static explicit operator int(Perro p)
       {
           return p._edad;
       }

       protected override string DatosCompletos()
       {
           return base.DatosCompletos() + "  edad " + this._edad;
       }

       protected override string Ficha()
       {
           StringBuilder sb = new StringBuilder();

           if (this._esAlfa)
           {
              
              sb.Append(base.Nombre + " " +  "edad " + this._edad);
           }

           else  sb.Append(this.DatosCompletos());


           return sb.ToString();

       }


       public override string ToString()
       {
           return this.Ficha();
       }

      

    }
}
