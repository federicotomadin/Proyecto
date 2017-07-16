using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Punto6F;
using System.Xml;
using System.Xml.Serialization;


namespace Entidades
{
        namespace Punto6F
        {
                [Serializable]
            public class AlumnoEgresado : Alumno, ISerializar, IDeserializar
            {
                public float promedio;
                public short promocion;




                public AlumnoEgresado()

                { }

                public AlumnoEgresado(Alumno a, float prome, short promo)
                    : base(a, a.legajo, a.nivel)                  
                   
                {
                    this.promedio = prome;
                    this.promocion = promo;
                }

          

                public bool Xml(string dato)
                {
                    try
                    {
                        using (XmlTextWriter escribeArchivo = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + dato, UTF8Encoding.UTF8))
                        {
                            XmlSerializer xml = new XmlSerializer(typeof(Humano));
                            xml.Serialize(escribeArchivo, this);
                          
                            return true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No se pudo serializar");
                        return false;
                    }
                }

                bool IDeserializar.Xml(string dato, out AlumnoEgresado alumno)
                {
                    try
                    {
                        using (XmlTextReader leeArchivo = new XmlTextReader(AppDomain.CurrentDomain.BaseDirectory + dato))
                        {
                            XmlSerializer xml = new XmlSerializer(typeof(Humano));
                            alumno = (AlumnoEgresado)xml.Deserialize(leeArchivo);
                           
                            return true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No se puedo deserializar");
                        alumno = null;
                        return false;
                    }
                }

            
            }
        
    }
}
