using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected  string _razonSocial;


        public float GananciaPorLocal { get { return CalcularGanancia(TipoLlamada.Local); } }

        public float GananciaPorProvincia { get { return CalcularGanancia(TipoLlamada.Provincia); } }

        public float GananciaTotal { get { return CalcularGanancia(TipoLlamada.Todas); } }

        public List<Llamada> Llamadas
        { get { return this._listaDeLlamadas; } }



       public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();

         }

       public Centralita(string nombreEmpresa):this()
       {
           this._razonSocial = nombreEmpresa;
 
       }

       private  float CalcularGanancia(TipoLlamada tipo)
       {
           float local=0;
           float provincial=0;
           
           foreach (Llamada item in _listaDeLlamadas)
           {
               if (item is Local) local += ((Local)item).CostoLlamada;
               if (item is Provincial) provincial += ((Provincial)item).CostoLlamada;
 
           }

           switch (tipo)
           {
               case TipoLlamada.Local: return local;
               case TipoLlamada.Provincia: return provincial;
               case TipoLlamada.Todas: return local + provincial;
               default: return 0;
           }
 
       }


       public void Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Razon Social " + this._razonSocial);
           sb.AppendLine("Ganancia por llamadas locales " + this.GananciaPorLocal);
           sb.AppendLine("Ganancia por llamadas provinciales " + this.GananciaPorProvincia);
           sb.AppendLine("Ganancia total " + this.GananciaTotal);
           sb.AppendLine("----------------------------------------");
           sb.AppendLine("Detalles de las llamadas");

           foreach (Llamada item in this._listaDeLlamadas)
           {
               if (item is Local) ((Local)item).Mostrar();
               if (item is Provincial) ((Provincial)item).Mostrar();
           }

 
       }

       public void OrdenarLlamadas()
       {

           this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

        
       }        
    }
}
