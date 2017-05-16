using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
   public class CentralitaException:Exception
    {
        #region Atributos

        private Exception _exceptionInterna;
        private string _nombreClase;
        private string _nombreMetodo;
        #endregion

        #region Propiedades

        public Exception ExcepcionInterna
        {
            get { return _exceptionInterna; }
        }

        public String NombreClase
        {
            get { return _nombreClase; }
        }

        public String NombreMetodo
        {
            get { return _nombreMetodo; }
        }

        #endregion


        #region Metodos

        public CentralitaException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;

        }


        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : this(mensaje, clase, metodo)
        {

        }
        #endregion
    }
}
