using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Obrero
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private int _legajo;
        private float _sueldo;

        public Obrero(string nombre, int dni, string apellido)
        {
            this._nombre = nombre;
            this._dni = dni;
            this._apellido = apellido;
            
        }

        public Obrero(string nombre, int dni, string apellido,int legajo,float sueldo)
        {
            this._nombre = nombre;
            this._dni = dni;
            this._apellido = apellido;
            this._legajo = legajo;
            this._sueldo = sueldo;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre" + this._nombre);
            sb.AppendLine("Apellido" + this._apellido);
            sb.AppendLine("Dni" + this._dni);
            sb.AppendLine("Legajo" + this._legajo);
            sb.AppendLine("Sueldo " + this._sueldo);

            return sb.ToString();
        }
    }
}
