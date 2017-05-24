using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;


namespace Consola
{
   public class ClaseQueHereda:Entidades.Externa.PersonaExterna
    {

       public ClaseQueHereda(string nombre, string apellido, int dni, Entidades.Externa.ESexo sexo)
           : base(nombre,apellido,dni,sexo)
       { }


       public string Nombre
       {
           get
           {
               return this._nombre;
           }
       }

       public string Apellido
       {
           get { return this._apellido; }
       }

       public int Edad
       {
           get { return this._edad; }
       }

       public ESexo Sexo
       {
           get { return this._sexo; }
       }



       public void ObtenerInfo()
       {
          Console.WriteLine(this.Nombre);
          Console.WriteLine(this.Apellido);
          Console.WriteLine(this.Edad);
          Console.WriteLine(this.Sexo);
       }

    }
}
