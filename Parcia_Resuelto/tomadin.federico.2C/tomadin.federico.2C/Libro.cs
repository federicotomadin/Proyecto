using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tomadin.federico._2C
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;


        public int CantidadDePaginas
        {
            get
            {

                if (_cantidadDePaginas == 0)
                {
                   
                    return _cantidadDePaginas=_generadorDePaginas.Next(10,580);
                }

                else return _cantidadDePaginas;
            }

        }


       static Libro()
        {
            _generadorDePaginas=new Random();
           
        }

        public Libro(float precio, string titulo, string nombre, string apellido)
            :this(precio,new Autor(nombre,titulo),titulo)
        { 
           this._precio=precio;
            this._titulo=titulo;
          
        
        }

    

        public Libro(float precio,Autor autor, string titulo)
        {
           this._precio=precio;
            this._titulo=titulo;
           this._autor=autor;
        }





        private static string Mostrar(Libro L)
        {
            StringBuilder sb=new StringBuilder();

            sb.AppendLine("Precio " + L._precio);
            sb.AppendLine("Titulo " + L._titulo);
            sb.AppendLine("Autor " + L._autor);
            sb.AppendLine("Cantidad de paginas "+ L.CantidadDePaginas);

            return sb.ToString();
        }

        public static bool operator ==(Libro a,Libro b)
        {
            if(a._titulo == b._titulo && a._autor==b._autor)
                return true;
            else return false;

        }

        public static bool operator !=(Libro a,Libro b)
        {
            return !(a==b);
        }

        public static explicit operator string(Libro L)
        {
            return Libro.Mostrar(L);
        }





    }
}


    
    

