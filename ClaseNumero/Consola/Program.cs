using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseNumero;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Numero n1 = new Numero(Int32.Parse("24"));
            Numero n2 = new Numero(Int32.Parse("-56"));
            Numero n3 = new Numero(Int32.Parse("59"));
            Numero n4 = new Numero(Int32.Parse("-18"));
            Numero n5 = new Numero(Int32.Parse("0"));


            double suma = n1 + n2;
            double resta = n3 - n4;
            double multi = n4 * n1;
            double divi = n3 / n5;

            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multi);
            Console.WriteLine(divi);

            Console.ReadLine();
            ColectoraDeNumeros colector = new ColectoraDeNumeros(ColectoraDeNumeros.ETipoNumero.Negativo);


            colector += n1;
            colector += n2;
            colector += n3;
            colector += n4;


            Console.WriteLine(colector.ToString());

            Console.ReadLine();

            colector -= n4;

            Console.WriteLine(colector.ToString());

            Console.ReadLine();
     
        }
    }
}
