using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial = new Comercial(100, 500.5f, 50);
            Privado privado = new Privado(1000, 321.5f, 10);

            //Auto auto = new Auto(100, "JJJ"); Auto abstracto

            Deportivo deportivo = new Deportivo(100, "HHH", 125);
            Familiar familiar = new Familiar(1000, "PPP", 8);

            Avion avion = new Avion(100, 65.3f);

            Carreta carreta = new Carreta(100);

            List<IAFIP> plist = new List<IAFIP>();
            List<IARBA> plistArba = new List<IARBA>();

            plist.Add(comercial);
            plist.Add(privado);
            plist.Add(deportivo);
            plist.Add(avion);
            //plist.Add(familiar);
            //plist.Add(carreta);

            plistArba.Add(comercial);
            plistArba.Add(privado);
            plistArba.Add(deportivo);
            plistArba.Add(avion);
            //plistArba.Add(familiar);
            plistArba.Add(carreta);

            foreach (IAFIP item in plist)
            {
                Console.WriteLine(Gestion.MostrarImpuestoNacional(item));
            }

            Console.ReadLine();

            foreach (IARBA item in plist)
            {
                Console.WriteLine(Gestion.MostrarImpuestoProvincial(item));
            }


            Console.ReadLine();

        }
    }
}
