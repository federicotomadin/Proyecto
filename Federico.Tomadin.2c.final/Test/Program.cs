using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Entidades.Inicio;
using Entidades;
using Entidades.Punto11;
using System.Windows.Forms;
using Entidades.Punto6F;



namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
              

            //Entidades.Inicio.Humano h = new Entidades.Inicio.Humano("Juan", ERaza.Mestiza);
            //Entidades.Inicio.Persona p = new Entidades.Inicio.Persona("Brian", "Lopez", ERaza.Cabeza, 17);
            //Entidades.Inicio.Alumno a = new Entidades.Inicio.Alumno(p, 123, ENivelDeEstudio.Primaria);
            //Entidades.Inicio.AlumnoEgresado ae = new Entidades.Inicio.AlumnoEgresado(a, 4.5f, 2017);

            //Console.WriteLine(p.MostrarBD());
            
            //Console.ReadLine();


            //Entidades.Punto2F.ClaseConstructores o = new Entidades.Punto2F.ClaseConstructores();


            //Entidades.Punto6F.Persona p = new Entidades.Punto6F.Persona("Brian", "Lopez", ERaza.Cabeza, 17);
            //Entidades.Punto6F.AlumnoEgresado a = new Entidades.Punto6F.AlumnoEgresado(new Entidades.Punto6F.Alumno(p, 123, ENivelDeEstudio.Primaria), 8.8f, 2001);

            //if (a.Xml("alumno.xml"))
            //{
            //    MessageBox.Show("Serializado OK");
            //}
            //else
            //{
            //    MessageBox.Show("NO Serializado");
            //}

            //if (((Entidades.Punto6F.IDeserializar)a).Xml("alumno.xml", out a))
            //{
            //    MessageBox.Show("Deserializado OK");
            //}
            //else
            //{
            //    MessageBox.Show("NO Deserializado");
            //}


            //Entidades.Punto6F.Persona p = new Entidades.Punto6F.Persona("Peter", "Müller", ERaza.Aria, 25);
            //MessageBox.Show(p.MostrarBD());

            Entidades.Punto11.Salon<Entidades.Punto6F.Persona> s = new Entidades.Punto11.Salon<Entidades.Punto6F.Persona>(2);

            try
            {
                Entidades.Punto6F.Persona p = new Entidades.Punto6F.Persona("Brian", "Lopez", ERaza.Cabeza, 67);
                Entidades.Punto6F.Persona p1 = new Entidades.Punto6F.Persona("Jose", "Lopez", ERaza.Negra, 47);
                Entidades.Punto6F.Persona p2 = new Entidades.Punto6F.Persona("Brian", "Smith", ERaza.Aria, 57);
                s.evento += s.Salon_SalonLlenoEvent;

                s += p;
                s += p1;
                s += p2;
            }
            catch (Entidades.Punto11.NoAgregaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
