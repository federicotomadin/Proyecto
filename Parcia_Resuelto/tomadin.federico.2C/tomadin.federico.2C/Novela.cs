using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomadin.federico._2C
{
    public class Novela:Libro
    {
     


        public EGenero genero;


     
       public Novela(string titulo, float precio, Autor autor ,EGenero genero)
            : base(precio,autor, titulo)
       {
            this.genero = genero;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((string)this);
            sb.AppendLine("Genero " + this.genero);

            return sb.ToString();
 
        }


        public static bool operator ==(Novela a,Novela b)
        {
            if (a.genero == b.genero && a == b)
                return true;
            else return false;

        }


        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }

    }
}
