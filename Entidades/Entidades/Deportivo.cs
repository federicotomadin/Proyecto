using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Deportivo:Auto,IAFIP,IARBA
    {
       private int _caballosFuerza;

       public Deportivo(double precio, string patente, int hp)
           : base(precio,patente)
       {

           this._caballosFuerza = hp;
 
       }


       double IAFIP.CalcularImpuesto()
       {
           return base._precio * 1.28;
       }

       double IARBA.CalcularImpuesto()
       {
           return base._precio *1.23;
       }


       public override void MostrarPrecio()
       {
           Console.WriteLine(((IARBA)this).CalcularImpuesto() + ((IAFIP)this).CalcularImpuesto());
       }

       public override void MostrarPatente()
       {
           Console.WriteLine(base._patente);
       }
    }
}
