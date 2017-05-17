using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita("Telefonica");

            Local local = new Local("115476105", "1154761606", 30f, 2.65f);
            Provincial provincia = new Provincial("115476105", "1154761606", 21f, Franja.Franja_1);
            Local local2 = new Local("5545545", "4545454", 45f, 1.99f);
            Provincial provincia2 = new Provincial(provincia, Franja.Franja_3);

            centralita.Llamadas.Add(local);
            centralita.Llamadas.Add(provincia);
            centralita.Llamadas.Add(local2);
            centralita.Llamadas.Add(provincia2);

            centralita.RutaDelArchivo = @"E:\Centralita.XML";

            centralita.Serializarse();
          
            Console.ReadLine();
        }
    }
}
