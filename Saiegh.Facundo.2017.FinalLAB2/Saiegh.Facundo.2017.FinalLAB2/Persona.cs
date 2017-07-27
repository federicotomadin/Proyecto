using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    
    {
       public  string apellido; //los pongo public para serializar
       public string nombre;
        public Persona(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        public Persona() { }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

    }
}
