using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  
        namespace Punto6F
        {
            public class Persona : Humano
            {
                public string apellido;
                public sbyte edad;


                public Persona()
                { }

                public Persona(string nombre, string ape, ERaza raza, sbyte ed)
                    : base(nombre, raza)
                {
                    base.nombre = nombre;
                    base.raza = raza;
                    this.apellido = ape;
                    this.edad = ed;
                }
            }
        
    

    }
}
