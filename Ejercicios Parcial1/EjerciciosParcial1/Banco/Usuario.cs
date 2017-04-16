using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Usuario
    {
        private string _apellido;
        private double _dni;
        private string _nombre;

        public double Dni
        {
            get
            {
                return this._dni;
            }
        }

        private string DevolverDatosFormatoString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre:" + this._nombre + "\n");
            sb.Append("Apellido:" + this._apellido + "\n");
            sb.Append("Dni:" + this._dni + "\n");

            return sb.ToString();
        }

        public static string Mostrar(Usuario UsuarioActual)
        {
            return UsuarioActual.DevolverDatosFormatoString();
        }

        public Usuario(string apellido, string nombre, double dni)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._dni = dni;
        }
    }
}
