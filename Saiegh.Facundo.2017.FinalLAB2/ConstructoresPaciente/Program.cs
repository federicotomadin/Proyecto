using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConstructoresPaciente
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente("nombre", "apellido");
            Console.WriteLine(p1.Turno);
            Paciente p2 = new Paciente("nombre", "apellido", 5);
            Console.WriteLine(p2.Turno);
            Paciente p3 = new Paciente("nombre", "apellido");
            Console.WriteLine(p3.Turno);

            Console.Read();
        }
    }

}
