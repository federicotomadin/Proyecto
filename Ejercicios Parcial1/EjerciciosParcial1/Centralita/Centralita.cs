using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float Local = 0;
            float Provincial = 0;
            float resultado = 0;


            foreach (Llamada item in this._listaDeLlamadas)
            {
                if (item is Local)
                {
                    Local += ((Local)item).CostoLlamada;
                }

                if (item is Provincial)
                {
                    Provincial += ((Provincial)item).CostoLlamada;
                }

            }

            if (tipo == TipoLlamada.Local)
            {
                resultado = Local;
            }
            if (tipo == TipoLlamada.Provincia)
            {
                resultado = Provincial;
            }
            else
            {
                resultado = Local + Provincial;
            }

            return resultado;
        }

        public float GananciaPorLocal
        {
            get
            {
               return  this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincia);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();

        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public List<Llamada> ListaLlamada
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            

            sb.Append("Razon Social:" + this._razonSocial + "\n");
            sb.Append("Ganancia Local:"+this.GananciaPorLocal+"\n");
            sb.Append("Ganancia Provincial:"+this.GananciaPorProvincial+"\n");
            sb.Append("Ganancia Total:"+this.GananciaTotal+"\n");

             Console.WriteLine(sb.ToString());

            foreach (Llamada item in this._listaDeLlamadas)
            {
                if (item is Local)
                {
                    ((Local)item).Mostrar();
                }

                if(item is Provincial)
                {
                    ((Provincial)item).Mostrar();
                }
            }
        }



        public void OrdenarLlamadas()
        {

            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }


    }
}
