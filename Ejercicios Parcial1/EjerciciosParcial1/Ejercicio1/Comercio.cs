using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;
using Ejercicio1Clase2;


namespace Ejercicio1Clase3
{
    class Comercio
    {
        private string _duenio;
        private List<Articulo> _misArticulos=new List<Articulo>();
        private List<Venta> _misventas=new List<Venta>();


        public Comercio(string duenio)
        {
            this._duenio = duenio;
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
             bool flag = false;

            foreach (Articulo item in this._misArticulos)
            {
               

                if (item == articuloComprado)
                {
                    flag = true;
                    item.Stock = item + articuloComprado;
                    break;
                }
            }

            if (flag == false)
            {
                this._misArticulos.Add(articuloComprado);
            }
        }


        public static void MostrarArticulos(Comercio ComercioAMostrar)
        {


            foreach (Articulo item in ComercioAMostrar._misArticulos)
            {
                Console.WriteLine(item.NombreYCodigo);
            }
        }

        public static void MostrarGanancia(Comercio ComercioParaResumen)
        {
            float ganancia=0;

            foreach (Venta item in ComercioParaResumen._misventas)
            {
                ganancia += item.RetornarGanancia();
            }

            Console.WriteLine(ganancia);
        }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        {
            Venta venta1 = new Venta(articuloSolicitado, cantidad);

            bool flag=false; //bandera que denota si hay cantidad disponible
            bool flag2 = false; 

            foreach (Articulo item in this._misArticulos)
            {
                if (item == articuloSolicitado)
                {
                    //bandera para saber si existe el articulo solicitado
                    flag2 = true;

                    if ((articuloSolicitado - cantidad) >= 0)
                    {
                        item.Stock = articuloSolicitado - cantidad;
                        this._misventas.Add(venta1);
                        flag = true;
                        break;
                    }

                }
               
            }

            if(flag==false && flag2==true)
            {
                    Console.WriteLine("No hay stock del articulo"+" "+ articuloSolicitado.NombreYCodigo);
                
            }

            if(flag2==false)
            {
                Console.WriteLine("Este producto no existe en nuestro comercio"+" " + articuloSolicitado.NombreYCodigo);
            }
           
          }
     }                    




        }


        
    

