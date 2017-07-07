using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializacionBin;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Federico", "Tomadin", 15);

            if (SerializarBinario.serializar(@"D:\Archivo.bin", p)) Console.WriteLine("Serializado");

            else Console.WriteLine("No Serializo");

            Console.ReadLine();



        }
    }
}
