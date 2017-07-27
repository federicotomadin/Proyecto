using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void finAtencionPaciente (Object obj, EventArgs ea);
  
    public abstract class Medico:Persona
    {
        public event finAtencionPaciente AtencionFinalizada;
        Paciente pacienteActual;
        protected static  Random tiempoAleatorio;
        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }
        public virtual  string EstaAtendiendoA
        {
            get
            {
                return this.pacienteActual.ToString();
            }
        }
        protected abstract void Atender();
        protected  void finalizarAtencion()
        {
            this.AtencionFinalizada(this, new EventArgs());
            this.pacienteActual = null;
        }
        public Medico(string nombre, string apellido):base(nombre, apellido)
        {
        }
         static Medico()
        {
            Medico.tiempoAleatorio = new Random();
        }

        //agrego esto para mostrar el nombre del medico en el form
         public override string ToString()
         {
             return  this.nombre + ", " + this.apellido;
         }
    }
}
