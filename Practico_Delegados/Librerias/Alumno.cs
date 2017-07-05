using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public  class Alumno
    {
        private string _apellido;
        private int _dni;
        private string _fotoAlumno;
        private string _nombre;


        public string Apellido { get; set; }

        public int Dni { get; set; }    

        public string FotoAlumno { get; set; }

        public string  Nombre { get; set; }


        public Alumno(string nombre, string apellido, int dni, string ruta)
        {

            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._fotoAlumno = ruta;
        
        }
    }
}
