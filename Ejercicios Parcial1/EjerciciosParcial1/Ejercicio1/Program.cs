using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;
using Ejercicio1Clase2;
using Ejercicio1Clase3;


namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercio ElBolicheDeToni = new Comercio("TONI"); 
            Articulo articuloUno = new Articulo(100, "Sprite", (float)2.5, 10); 
            Articulo articuloDos = new Articulo(101, "Fanta", (float)2.5, 10);
            Articulo articuloTres = new Articulo(100, "Sprite", (float)2.5, 25); 
            Articulo articuloCuatro = new Articulo(103, "Quattro", (float)2.5, 10);
            Articulo articuloCinco = new Articulo(103, "Pepsi", (float)2.5, 10);

            //Console.WriteLine(articuloUno.PrecioVenta);
            //articuloUno.PrecioCosto = 10;
            //Console.WriteLine(articuloUno.PrecioVenta);


            ElBolicheDeToni.ComprarArticulo(articuloUno);
            ElBolicheDeToni.ComprarArticulo(articuloDos); 
            ElBolicheDeToni.ComprarArticulo(articuloTres);
            ElBolicheDeToni.ComprarArticulo(articuloCuatro); 
            Console.WriteLine("El Boliche De Tony");
            Console.WriteLine("Vender:");
            ElBolicheDeToni.VenderArticulo(articuloUno, 1);
            ElBolicheDeToni.VenderArticulo(articuloDos, 1); 
            ElBolicheDeToni.VenderArticulo(articuloTres, 1); 
            ElBolicheDeToni.VenderArticulo(articuloDos, 1); 
            ElBolicheDeToni.VenderArticulo(articuloTres, 20);
            ElBolicheDeToni.VenderArticulo(articuloTres, 50); 
            ElBolicheDeToni.VenderArticulo(articuloCuatro, 1); 
            ElBolicheDeToni.VenderArticulo(articuloCinco, 1); 
            Console.WriteLine();
            Comercio.MostrarArticulos(ElBolicheDeToni); 
            Console.WriteLine(); 
            Comercio.MostrarGanancia(ElBolicheDeToni); 
            Console.ReadLine();   
        }
    }
}
