using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> lista = new List<Transporte>();

           


            Caballo caballo = new Caballo(2, EVelocidad.Baja, "Tordillo");

            Cohete cohete = new Cohete(4, EVelocidad.Hiper, "Nasa", 5);

            Auto auto = new Auto(4, EVelocidad.Media, 4);


           //Console.WriteLine(caballo.Acelerar());
           //Console.WriteLine(auto.Acelerar());
           //Console.WriteLine(cohete.Acelerar());

           //Console.WriteLine(caballo.Frenar());
           //Console.WriteLine(auto.Frenar());
           //Console.WriteLine(cohete.Frenar());

            lista.Add(caballo);
            lista.Add(cohete);
            lista.Add(auto);


            foreach (Transporte item in lista)
            {
                
                Console.WriteLine(item.Frenar());
                Console.WriteLine(item.Acelerar());
                Console.WriteLine(item.Detalle);
               
              
            }
            

            Console.ReadLine();

        }
    }
}
