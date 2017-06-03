using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbrerias
{
    public class Grupo
    {
        private string _nombre;
        private static EtipoManada _tipo;
        private List<Mascota> _manada;


        static Grupo()
        {
            Grupo._tipo = EtipoManada.Unica;
        }


        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        public Grupo(string nombre):this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre,EtipoManada tipo):this(nombre)
        {
           
            Grupo._tipo = tipo;
        }



        public EtipoManada Tipo
        {
            set { Grupo._tipo = value; }
 
        }


        public static bool operator ==(Grupo g, Mascota m)
        {
            foreach (Mascota item in g._manada)
            {
                if(item.Equals(m))
                {
                    if(item==m) return true;
                }
            }
            return false;
        }



        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g == m)
            {
                Console.WriteLine("Ya esta el " + m.Nombre + m.Raza +  "en el grupo");
                return g;
            }

            else g._manada.Add(m);
            return g;

        }


    
        public static Grupo operator -(Grupo g, Mascota m)
        {
           
                if (g == m)
                {
                    g._manada.Remove(m);
                
                }
                else Console.WriteLine("No esta el " + m.Nombre + "en el grupo");
             


               
                return g;
            
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Grupo: " + g._nombre + "-tipo: " + Grupo._tipo);
            sb.AppendLine("Integrantes" + "(" + g._manada.Count + ")");
            foreach (Mascota item in g._manada)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
            
        }



    }
}
