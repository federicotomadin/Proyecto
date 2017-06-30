using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    public class Class1:EventArgs
    {
        private double atributo;

        public Class1(double atrib)
        {
            this.atributo= atrib;
        }

        public double EventoArgs
        {
            get { return this.atributo; }
        }

    }
}
