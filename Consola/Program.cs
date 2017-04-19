using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;



namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Tempera tempera1 = new Tempera(ConsoleColor.Black, "Marca1", 10);
            Tempera tempera2 = new Tempera(ConsoleColor.Black, "Marca2", 11);

             Tempera tempera3 = new Tempera(ConsoleColor.Black, "Marca3", 11);
             Tempera tempera4 = new Tempera(ConsoleColor.Black, "Marca4", 11);


            //prueba de sobrecarga explicita

           string variable = (string)tempera1;
           Console.WriteLine(variable);

           int valor = tempera1;

            Console.ReadLine();




            Paleta paleta = new Paleta(5);
            Paleta paleta2 = new Paleta(5);


            paleta += tempera1;
            paleta += tempera1;

            paleta2 += tempera1;
            paleta2 += tempera1;

            Console.WriteLine((string)tempera1);

            Console.ReadLine();

            //paleta += tempera2;

            Console.WriteLine((string)paleta);

            Console.ReadLine();

            paleta += paleta2;

            Console.WriteLine((string)paleta);

            Console.ReadLine();








        }
    }
}
