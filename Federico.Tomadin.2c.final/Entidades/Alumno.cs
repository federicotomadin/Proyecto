using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 
    
        namespace Punto6F
        {
            [Serializable]
            public class Alumno : Persona
            {
                public short legajo;

                public ENivelDeEstudio nivel;

                public Alumno()
                { }
           

                public Alumno(Persona p, short leg, ENivelDeEstudio niv)
                    : base(p.nombre, p.apellido, p.raza, p.edad)
                {
                    this.legajo = leg;
                    this.nivel = niv;
                }

               
            }
        
       
    }
}
