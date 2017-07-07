using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerializacionBin
{
    [Serializable]
   public class Persona
    {
       private string _name;
       private string _surname;
       private int _edad;

       public Persona()
       { }

       public Persona(string nombre, string apellido, int edad)
       {
           this._name = nombre;
           this._surname = apellido;
           this._edad = edad;
       }
    }
}
