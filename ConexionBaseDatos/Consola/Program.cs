using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBaseDatos;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDeDatos baseDatos = new BaseDeDatos();

            

            List<Persona> padron=baseDatos.TraerTodos();

            foreach (Persona item in padron)
            {

                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();


            Persona persona = new Persona();
            persona.apellido = "Tomadin";
            persona.nombre = "federico";
            persona.edad = 30;

            if (baseDatos.Agregar(persona))
            {
                Console.WriteLine("se agrego");
            }

            Console.ReadLine();

          
            Console.ReadLine();

           foreach (Persona item in padron)
            {

                Console.WriteLine(item.ToString());
            }

           Console.ReadLine();

        }
    }
}
