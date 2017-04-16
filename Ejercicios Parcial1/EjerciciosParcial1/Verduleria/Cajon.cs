using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verduleria
{
    class Cajon
    {
        private List<Fruta> _frutas;
        private int _volumen;

        private Cajon()
        {
            this._frutas=new List<Fruta>();
        }

        public Cajon(int volumen)
            : this()
        {
            this._volumen = volumen;
        }

        public int CalcularEspacioDisponible()
        {
            int espacio = 0;
            int disponible;


            foreach (Fruta item in this._frutas)
            {
                espacio += item.volumen;
            }

            disponible = this._volumen - espacio;
            return disponible;
        }


        public string MostrarContenido()
        {
            int espacio = 0;
            
            StringBuilder sb = new StringBuilder();

            foreach (Fruta item in this._frutas)
            {
                espacio += item.volumen;
                sb.Append("Peso:"+item.peso+"\n");
                sb.Append("Peso:" + item.volumen + "\n");

            }

            sb.Append("Espacio ocupado:" + espacio+"\n");
            sb.Append("Espacio Total del cajon:" + this._volumen + "\n");

            return sb.ToString();

        }

        public void AgregarFruta(Fruta uno)
        {
            if (this.CalcularEspacioDisponible() > uno.volumen)
            {
                this._frutas.Add(uno);
            }
        }

        public void QuitarFruta()
        {
            if (this._frutas.Count > 0)
            {
                Random random = new Random();

                this._frutas.RemoveAt(random.Next(0, this._frutas.Count));
            }

        }

        }
    }

