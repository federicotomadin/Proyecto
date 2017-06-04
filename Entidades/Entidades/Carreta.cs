using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Carreta:Vehiculo,IARBA
    {



       public Carreta(double precio):base(precio)
       {
          
       }


       public override void MostrarPrecio()
       {
           Console.WriteLine(this._precio);
       }


       double IARBA.CalcularImpuesto()
       {
           return base._precio * 1.18;
       }
    }
}
