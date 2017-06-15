using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBaseDatos
{
  public  class BaseDeDatos
    {

      private SqlConnection _conexion;
      private SqlCommand _comando;

      


      public BaseDeDatos()
      {
          this._conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion);
          this._comando = new SqlCommand();

          this._comando.CommandType = CommandType.Text;
          this._comando.Connection = this._conexion;


   
      }

      public List<Persona> TraerTodos()
      {
          this._comando.CommandText = "SELECT * FROM personas TABLA ORDER BY id ";
          List<Persona> persona = new List<Persona>();
          try
          {
              
              this._conexion.Open();
              SqlDataReader info;
              
              info = this._comando.ExecuteReader();
              while (info.Read())
              {
                  Persona p = new Persona();

                      p.id = (int)info[0];
                      p.apellido = info[1].ToString();
                      p.nombre = info[2].ToString();
                      p.edad = (int)info[3];
                      persona.Add(p);
                   
              }
              info.Close();
              this._conexion.Close();

          }
          catch (SqlException)
          {

              throw;
          }

          return persona;
         
      }


      public bool Agregar(Persona p)
      {
         

          try
          {

              this._comando.CommandText = "INSERT INTO Persona (apellido,nombre,edad) VALUES('" + p.apellido + "','" + p.nombre + "'," + p.edad + ")";
              this._conexion.Open();
              this._comando.ExecuteNonQuery();
              this._conexion.Close();


          }
          catch (SqlException)
          {
              return false;

          }
          

              return true;
      }



    }
}
