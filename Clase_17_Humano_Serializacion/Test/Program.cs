using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase_17_Humano;
using System.Xml;
using System.Xml.Serialization;

namespace Test
{
    class Program
    {
        private static bool SerializarPersona(Persona persona)
        {
            

            try
            {
                using (XmlTextWriter escribeArchivo = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "persona.xml", UTF8Encoding.UTF8))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    xml.Serialize(escribeArchivo, persona);
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

        private static bool DeSerializarPersona()
        {
            try
            {
                using (XmlTextReader leeArchivo = new XmlTextReader(AppDomain.CurrentDomain.BaseDirectory + "persona.xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    Persona persona = (Persona)xml.Deserialize(leeArchivo);
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
                


        static void Main(string[] args)
        {
            //@"D:\Persona.txt";
            //string cadena="";

            //try
            //{
            //    Persona persona = new Persona(32191299, "federico", "tomadin");
            //    persona.Leer(out cadena);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("No se puedo guardar el archivo");
            //}

            //Console.WriteLine(cadena);

        Persona persona = new Persona(32191299, "federico", "tomadin");

            try
            {

                Program.SerializarPersona(persona);
            }
            catch (Exception)
            {
                
            }

            Console.ReadLine();

            try
            {

                Program.DeSerializarPersona();
            }
            catch (Exception)
            {

            }



           Console.ReadLine();

           Console.WriteLine(persona.ToString());

           Console.ReadLine();
        }
    }
}
