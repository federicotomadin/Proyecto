using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Alumno
    {
      private string _nombre;
      private string _apellido;
      private int _dni;
      private List<float> _notas;
      private string _curso;


      public Alumno(string nombre, string apellido, int dni)
      {
          this._nombre = nombre;
          this._apellido = apellido;
          this._dni = dni;
      }


      public Alumno(string nombre, string apellido, int dni,string curso)
      {
          this._nombre = nombre;
          this._apellido = apellido;
          this._dni = dni;
          this._curso = curso;
      }


      public string Mostrar()
      {
          StringBuilder sb = new StringBuilder();

          sb.AppendLine("Nombre" + this._nombre);
          sb.AppendLine("Apellido" + this._apellido);
          sb.AppendLine("Dni" + this._dni);
          sb.AppendLine("Curso" + this._curso);
          sb.AppendLine("Las notas son: ");

          foreach (float item in _notas)
          {
              sb.AppendLine(item.ToString());
          }

          return sb.ToString();
      }
    }
}
