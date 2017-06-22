using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIbreria;
using System.IO;

namespace Test
{
    class Program
    {

        public static void Guardar()
        {

            try
            {
                using (StreamWriter txt = new StreamWriter(@"D:\\Exceptiones.log", false))
                {

                   
                    txt.WriteLine(DateTime.Now);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        static void Main(string[] args)
        {

            Cartuchera<Utiles> utiles = new Cartuchera<Utiles>(3,"ACME");

            Lapicera lapicera1 = new Lapicera(ConsoleColor.Blue, "Trazo Grueso");
            Lapicera lapicera2 = new Lapicera(ConsoleColor.DarkRed, "Trazo Fino");
            Goma goma1 = new Goma(true);
            Goma goma2 = new Goma(false);

            try
            {
                utiles += lapicera1;
                utiles += lapicera2;
                utiles += goma1;
                utiles += goma2;
            }
            catch (CartucheraLlenaException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Program.Guardar();
            }


            utiles.SerializarXml(@"D:\\Cartuchera.xml");
           
            string ruta=@"D:\\Goma.xml";

            utiles.Extencion(ruta);

            Console.ReadLine();


            utiles.MuestraBase();

            Console.ReadLine();
        }
    }
}
