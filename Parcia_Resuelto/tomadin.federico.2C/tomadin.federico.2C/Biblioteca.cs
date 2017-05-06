using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomadin.federico._2C
{
    public class Biblioteca
    {
      

        private int _capacidad;
        private List<Libro> _libros;


        //public double PrecioDeManuales
        //{
        //    get
        //    {
        //        double acumulador = 0;
        //        foreach (Libro item in _libros)
        //        {
        //            if (item is Manual)
        //            {
        //                ((Libro)item)._precio;
 
        //            }
        //        }
            
        //         }
        //}


        //public double PrecioDeNovelas
        //{
        //    get { }
        //}


        //public double PrecioTotal
        //{
        //    get { }
        //}




        private Biblioteca()
        {
            _libros = new List<Libro>();
        }

        private Biblioteca(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }


        //private double ObtenerPrecio(ELibro tipoLibro)
        //{ 
            

        //    foreach(Libro item in _libros)

        //        switch(tipoLibro)
        //        {
        //            case ELibro.Manual: return ((Libro)item).
                       
        //            case ELibro.Novela: return 29.95;
                       
        //            case ELibro.Ambos: return 25.66 + 29.95;
                       
        //            default: return 0;
                   
        //        }
        //}


        public static implicit  operator Biblioteca(int capacidad)
        {
            Biblioteca biblio=new Biblioteca(capacidad);

            return biblio;
        }


        public static bool operator ==(Biblioteca e, Libro l)
        {
            foreach (Libro item in e._libros)
            {
                if (item == l) return true;
            }
            return false;
        }



        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }

        public static Biblioteca operator +(Biblioteca e, Libro L)
        {
            if (e == L)
                return e;


            else if (e._libros.Count < e._capacidad)
                e._libros.Add(L);
            return e;
        }


        public static string Mostrar(Biblioteca biblio)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad " + biblio._capacidad);

            foreach (Libro item in biblio._libros)
            {
                if (item is Novela) sb.AppendLine(((Novela)item).Mostrar());
                if (item is Manual) sb.AppendLine(((Manual)item).Mostrar());
            }

            return sb.ToString();
        }

        


    }
}
