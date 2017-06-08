using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase_17_Humano
{
   public class Aula
    {
       private bool _internet;
       private List<Persona> _listadoDePersonas;
       private string _nombre;
       private int _numero;


       public bool Internet
       {
           set { this._internet = value; }
       }

       public List<Persona> ListadoDePersona
       {
           get { return this._listadoDePersonas; }
       }

       public string Nombre
       {
           get { return this._nombre; }
       }

       public int Numero
       {
           get { return this._numero; }
           set { this._numero = value; }
       }

       public Aula()
       {
           this._listadoDePersonas = new List<Persona>();
       }

       public Aula(int numero, bool internet, string nombre)
       {
           this._numero = numero;
           this._internet = internet;
           this._nombre = nombre;
       }

       //public bool serializarMe()
       //{
       //    using (XmlTextWriter xml=new XmlTextWriter())
       

       //}
    }
}
