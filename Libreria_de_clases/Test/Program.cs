using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_de_clases;

namespace Test
{
    class Program
    {
        //mi manejador de eventos tiene que tener la misma firma que el delegado (mismo tipo y sin parametros)
        //lo declaro estatico para que se mas facil de utilizar.
        static void ManejadorEvent()
        {
            Console.WriteLine("Se ha superado el limite de sueldo");
        }

        void ManejadorEvent2()
        {
            Console.WriteLine("Otro manejador de eventos");
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            Empleado emp = new Empleado("federico", "tomadin", 105067);
            emp.sueldoEvent += Program.ManejadorEvent;
            emp.sueldoEvent += prog.ManejadorEvent2;
            try
            {
                emp.Sueldo = 2600;
                Console.WriteLine(emp.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Se ingreso un valor negativo");
            }
                

            
    
            Console.ReadLine();

        }
    }
}
