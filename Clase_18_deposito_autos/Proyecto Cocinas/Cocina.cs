using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Cocinas
{
   public class Cocina
    {
       private int _codigo;
       private bool _esIndustrial;
       private double _precio;

       public int Codigo
       { get { return this._codigo; } }

       public bool EsIndustrial
       { get { return this._esIndustrial; } }

       public double Precio
       { get { return this._precio; } }


       public Cocina(int codigo, double precio, bool esIndustrial)
       {
           this._codigo = codigo;
           this._precio = precio;
           this._esIndustrial = esIndustrial;
       }


       public override bool Equals(object obj)
       {
           if (obj is Cocina && (Cocina)obj == this) return true;
           else return false;
       }

       public static bool operator ==(Cocina a, Cocina b)
       {
           if (a._codigo == b._codigo && a._precio == b._precio && a._esIndustrial==b._esIndustrial)
               return true;
           else return false;
       }


       public static bool operator !=(Cocina a, Cocina b)
       {
           return !(a == b);
       }

       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Codigo " + this._codigo + " " + "-" + " " + "Precio " + this._precio + " " + " - " + " " + this._esIndustrial);

           return sb.ToString();
       }


    }
}
