using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libreria_de_clases
{
   public  delegate void delegadoSueldo();
    public delegate void sueldoMejorado(object obj, EventArgs eve);

   public class Empleado
    {
       public string nombre;
       public string apellido;
       public int legajo;
       private double _sueldo;
       public event delegadoSueldo sueldoEvent;
       public event sueldoMejorado sueldoEventMejorado;


     

       public Empleado(string nom, string ape, int leg)
       {
           this.nombre = nom;
           this.apellido = ape;
           this.legajo = leg;
       }

       public double Sueldo
       {
           get { return this._sueldo; }
           set {
               if (value < 0) throw new Exception();
               else  if (value > 20000) this.sueldoEventMejorado(this, new EventArgs());
               else  if (value > 2500)  this.sueldoEvent();
              
                            
               else  this._sueldo = value; }
       }

       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Nombre " + this.nombre);
           sb.AppendLine("Apellido " + this.apellido);
           sb.AppendLine("Legajo " + this.legajo);
           sb.AppendLine("Sueldo " + this.Sueldo);

           return sb.ToString();

       }

     

    }
}
