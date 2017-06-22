using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbreria
{
   public class Lapicera:Utiles
    {

       private ConsoleColor _color;
       private string _trazo;

       public Lapicera()
       { }

       public Lapicera(ConsoleColor color, string trazo)
           : base()
       {
           this._color=color;
           this._trazo = trazo;


       }

       public ConsoleColor color
       {
           get { return this._color; }
           set { this._color = value; }
       }

       public string Trazo
       {
           get { return this._trazo; }
           set { this._trazo = value; }
       }



       public override int Precio
       {
           get;
           set;
       }

       public override string Marca
       {
           get;
           set;
       }


       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine(base.UtilesToString());
           sb.AppendLine("Color " + this._color);
           sb.AppendLine("Trazo " + this._trazo);

           return sb.ToString();
       }


    }
}
