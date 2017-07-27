using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
   
    public class MEspecialista:Medico, IMedico
    {
        public enum EEspecialidad { Traumatologo, Odontologo }
        EEspecialidad especialidad;
        protected override void Atender()
        {
            int intVal = Medico.tiempoAleatorio.Next(5000, 10000);
            Thread.Sleep(intVal);
            base.finalizarAtencion();
        }
        public MEspecialista(string nombre, string apellido, EEspecialidad espe):base(nombre, apellido)
        {
            this.especialidad = espe;
        }

        public void iniciarAtencion(Paciente p)
        {
            Thread hilo = new Thread(this.Atender);
            hilo.Start();
        }
    }
}
