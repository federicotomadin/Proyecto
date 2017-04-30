using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Primer_Parcial
{
    class Program
    {
        public static int OrdenarProductos(Producto uno, Producto dos)
        {
            int valor = 0;
            if(((int)uno).ToString().CompareTo(((int)dos).ToString())>0)  valor=1;


            if (((int)uno).ToString().CompareTo(((int)dos).ToString()) < 0) valor = -1;
           

            return valor;
              
        }


        static void Main(string[] args)
        {

            Galletita galleta1 = new Galletita(12226, Gaseosa.EMarcaProducto.Manaos, 50, 2);
            Galletita galleta2 = new Galletita(12226, Gaseosa.EMarcaProducto.Manaos, 50, 2);

            Console.WriteLine(galleta1.ToString());

            Console.ReadLine();















            //Gaseosa gaseosa = new Gaseosa(12222, Gaseosa.EMarcaProducto.Manaos, 50, 2);

            //Console.WriteLine(gaseosa.MostrarGaseosa());

            //Console.ReadLine();


            //Estante estante1 = new Estante(5);
            //Estante estante2 = new Estante(5);
            //Estante estante3 = new Estante(5);

            //Gaseosa gaseosa2 = new Gaseosa(12223, Gaseosa.EMarcaProducto.Manaos, 50, 2);

            //Jugo jugo1 = new Jugo(12224, Gaseosa.EMarcaProducto.Manaos, 50, Jugo.ESaborJugo.Pasable);
            //Jugo jugo2 = new Jugo(12225, Gaseosa.EMarcaProducto.Manaos, 50, Jugo.ESaborJugo.Pasable);

            //Galletita galleta1 = new Galletita(12226, Gaseosa.EMarcaProducto.Manaos, 50, 2);
            //Galletita galleta2 = new Galletita(12227, Gaseosa.EMarcaProducto.Manaos, 50, 2);


            //estante1.AgregarProducto(gaseosa);
            //estante1.AgregarProducto(gaseosa2);
            //estante1.AgregarProducto(galleta1);
            //estante1.AgregarProducto(gaseosa2);


            //Console.WriteLine(estante1.MostrarEstante(estante1));

            //Console.ReadLine();

            //Console.WriteLine("------------------------------------------------------------------------");


            //estante1.GetProductos().Sort(Program.OrdenarProductos);

            //Console.WriteLine(estante1.MostrarEstante(estante1));

          

            //Console.ReadLine();
          




        }
    }
}
