using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
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


       public static bool operator ==(Centralita central, Llamada nuevaLlamada)
       {
           foreach (Llamada item in central._listaDeLlamadas)
           {
               if (item == nuevaLlamada) return true;
           }
           return false;
       }

       public static bool operator !=(Centralita central, Llamada nuevaLlamada)
       {
           return !(central == nuevaLlamada);

       }

       public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
       {
           if (central == nuevaLlamada)
           {
               Console.WriteLine("La llamada ya se encuentra en la central");
               return central;
           }

           else
           {
               central._listaDeLlamadas.Add(nuevaLlamada);
               return central;
           }
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


       public override string ToString()
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
               if (item is Local) sb.AppendLine(item.ToString());
               if (item is Provincial) sb.AppendLine(item.ToString());
           }

           return sb.ToString();
 
       }

       public void OrdenarLlamadas()
       {

           this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

        
       }

       private void AgregarLlamada(Llamada nuevaLlamada)
       {
           this._listaDeLlamadas.Add(nuevaLlamada);
       }


       


    
    }
}
