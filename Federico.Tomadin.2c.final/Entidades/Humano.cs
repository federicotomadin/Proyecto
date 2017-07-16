using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Entidades
{
  
namespace Punto6F
{
    [Serializable]
    [XmlInclude(typeof(AlumnoEgresado))]
   
    public class Humano
    {
        public string nombre;

        public ERaza raza;

        public Humano()
        { }

        public Humano(string nom, ERaza raz)
        {
            this.nombre = nom;
            this.raza = raz;
        }

    

    }
    }
}
