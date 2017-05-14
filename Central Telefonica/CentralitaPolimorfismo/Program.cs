using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita("Telefonica");

            Local local = new Local("115476107", "1154761606", 30f, 2.65f);
            Provincial provincia = new Provincial("114476105", "1154761606", 21f, Franja.Franja_1);
            Local local2 = new Local("115476105", "1154761606", 45f, 1.99f);
            Provincial provincia2 = new Provincial(provincia, Franja.Franja_3);


            centralita += local;
            centralita += provincia;
            centralita += local2;
            centralita += provincia2;


            Console.WriteLine(centralita.ToString());

            Console.ReadLine();


        }
    }
}
