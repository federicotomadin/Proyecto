using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_15;
using Entidades.Externa;
using Entidades.Externa.Sellada;


namespace Consola
{
    class Program
    {
       


        static void Main(string[] args)
        {
            Persona persona = new Persona("federico", "tomadin", 30, Persona.ESexo.masculo);

             ClaseQueHereda clase_hereda = new ClaseQueHereda("Juan", "Gallego", 25,Entidades.Externa.ESexo.Masculino);

             Entidades.Externa.Sellada.PersonaExternaSellada perSellada = new PersonaExternaSellada("Jose", "Arambulo", 15, Entidades.Externa.Sellada.ESexo.Masculino);


             string Hola = "Hola";

            Console.WriteLine(Hola.Cantidad());
             Console.ReadLine();



            persona.ObtenerInfo();
            Console.ReadLine();
            clase_hereda.ObtenerInfo();
            Console.ReadLine();


            perSellada.ObtenerInfo();

            Console.ReadLine();
            


        

        }



    }
}
