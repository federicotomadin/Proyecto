using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Paciente: Persona
    {
      public   int turno; //pubnlic para serializar
      public static int ultimoTurnoDado;
        public int Turno
        {
            get
            {
                return this.turno;
            }
        }

        public string Nombre
        {
            get
            {
                return base.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public Paciente(string nombre, string apellido, int turno)
            : this(nombre, apellido)
        {
            this.turno = turno;
            Paciente.ultimoTurnoDado = turno;
        }

        public Paciente(string nombre, string apellido)
            : base(nombre, apellido)
        {
            Paciente.ultimoTurnoDado++;
            this.turno = Paciente.ultimoTurnoDado;
        }

        public override string ToString()
        {
            return "Turno Nº:" + this.Turno + ": " + this.nombre + ", " + this.apellido;
        }

        static Paciente()
        {
            Paciente.ultimoTurnoDado = 0;
        }

        //para serializar:
        public Paciente() { }
    }
}
