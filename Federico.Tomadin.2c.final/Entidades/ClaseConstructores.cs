using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{ 
namespace Punto2F
{
    public class ClaseConstructores
    {

        public string parametro1;
        public string parametro2;

        static ClaseConstructores()
        {

            MessageBox.Show("Constructor Estatico");

        }

        private ClaseConstructores(string param1, string param2):this()
            
        {
            MessageBox.Show("Constructor de instancia que recibe dos parametros");
         
          

        }

        public ClaseConstructores()
        {
            MessageBox.Show("Constructor publico por default");
            this.PropiedadEscritura = "asdfasd";
            this.parametro1 = this.PropiedadLectura;
            this.MetodoInstancia();
            this.MetodoClase();
        }

        public string PropiedadEscritura
        {
            set
            {
                MessageBox.Show("Propiedad de Escritura");
                this.parametro1 = value;

            }
        }

        public string PropiedadLectura
        {
            get
            {
                MessageBox.Show("Propiedad de lectura");
                return this.parametro1;

            }

        }

        public string MetodoInstancia()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(parametro1);
            sb.AppendLine(parametro2);
            MessageBox.Show("Metodo de Instancia");

            return sb.ToString();
        }

        public Punto2F.ClaseConstructores MetodoClase()
        {
            MessageBox.Show("Metodo de Clase");
            return this;

        }
    }

    }
}
