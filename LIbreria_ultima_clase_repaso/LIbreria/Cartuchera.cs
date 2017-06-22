using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;

namespace LIbreria
{
    [Serializable]
    public class Cartuchera<T>:ISerializable
    {
        private int _capacidad;
        private List<T> _utiles;
        private string _marca;

        private  SqlConnection _conexion;
        private  SqlCommand _comando;


        public int Capacidad
        {
            get { return this._capacidad; }
            set { this._capacidad=value;}
        }

        public string Marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }



        public Cartuchera()
        {
            this._utiles = new List<T>();
        }

        public Cartuchera(int capacidad, string marca):this()
        {
            this._capacidad = capacidad;
           
            this._marca = marca;
        }

        public List<T> UtilesProp
        {
            get { return this._utiles; }
        }


        public static Cartuchera<T> operator +(Cartuchera<T> c,T uti)
        {
          
            if (c._utiles.Count < c._capacidad)
                c._utiles.Add(uti);
               
                

            else throw new CartucheraLlenaException();

            return c;

        }


        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();

            sb.AppendLine("Capacidad " + this._capacidad);           
            sb.AppendLine("Marca " + this._marca);

            sb.AppendLine("Utiles ");

            foreach (T item in this._utiles)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
 	
        }




        public bool SerializarXml(string dato)
        {
            try
            {
                using (XmlTextWriter escribeArchivo = new XmlTextWriter(dato, UTF8Encoding.UTF8))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Cartuchera<T>));
                    xml.Serialize(escribeArchivo,this);
                    Console.WriteLine("Serializo sin problemas");
                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo serializar");
                return false;
            }             
        }

        public bool Desderializar(string dato)
        {
            try
            {
                using (XmlTextReader leeArchivo = new XmlTextReader(dato))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Cartuchera<T>));
                    Cartuchera<T> cartuchera = (Cartuchera<T>)xml.Deserialize(leeArchivo);
                    Console.WriteLine("Se deserializo correctamente");
                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se puedo deserializar");
                return false;
            }
        }


        public  void MuestraBase()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion);
            this._comando = new SqlCommand();

            this._comando.CommandType = CommandType.Text;
            this._comando.Connection = this._conexion;



             this._comando.CommandText = "SELECT * FROM elementos TABLA ORDER BY id ";
           


              try
          {
              
              _conexion.Open();
           
              SqlDataReader info;
              
              info = this._comando.ExecuteReader();
              while (info.Read())
              {
                

     Console.WriteLine(" {0} {1} {2} {3} {4} {5} ", info[0].ToString(),info[1],info[2].ToString(),info[3].ToString(),info[4],info[5].ToString()) ;
                                   
                   
              }
              info.Close();
              this._conexion.Close();

          }
          catch (Exception e)
          {

              Console.WriteLine(e.Message);
          }

         
         
      


 
        }
    }
}
