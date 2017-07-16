using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Punto6F;
using System.Data.SqlClient;
using System.Data;


namespace Entidades
{
   public static class Extensora
    {
        private static SqlConnection _conexion;
        private static SqlCommand _comando;





        public static string MostrarBD(this Entidades.Punto6F.Persona person)
        {
            _conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion);
            _comando = new SqlCommand();

            _comando.CommandType = CommandType.Text;
            _comando.Connection = _conexion;
            StringBuilder sb = new StringBuilder();

            _comando.CommandText = "SELECT * FROM personas ";


            try
            {

                _conexion.Open();
                SqlDataReader info;

                info = _comando.ExecuteReader();
                while (info.Read())
                {


                    sb.AppendLine(info[0].ToString());
                    sb.AppendLine(info[1].ToString());
                    sb.AppendLine(info[2].ToString());
                    sb.AppendLine(info[3].ToString());




                }
                info.Close();
                _conexion.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            return sb.ToString();


        }
    }
}
