using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LIbreria
{
 [Serializable]
 [XmlInclude(typeof(Goma))]
 [XmlInclude(typeof(Lapicera))]

    public abstract class Utiles
    {
        //protected int _precio;
        //protected string _marca;


        public Utiles()
        { }


        public abstract int Precio
        {
            get;
            set;
        }

        public abstract string Marca
        {
            get;
            set;
        }

        protected virtual string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Precio " + this.Precio);
            sb.AppendLine("Marca " + this.Marca);

            return sb.ToString();
        } 
    
    }
}
